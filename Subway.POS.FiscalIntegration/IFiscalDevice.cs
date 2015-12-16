using System;
using System.Collections.Generic;

namespace Subway.POS.FiscalIntegration
{
    public interface IFiscalDevice
    {
        /// <summary>
        ///   During POS application startup the configuration bundle for the fiscal module must be created and passed to the module. The preferred configuration type is via a business entity representing the initialization parameters. Object will contain the following fields and input parameters: 
        ///   a) Fiscal header and footer 
        ///   b) Tax rates tables. 
        ///   c) Menu Items list (Item PLU, Name, Tax Id, Full item price) 
        ///   d) Communication parameters (communication ports, baud rate, tcp address, USB configuration parameters required during initialization that are set at the beginning of operation). 
        ///   e) Operation parameters (print flags, layout markers and configuration and any other functional parameter required during initialization that are set at the beginning of operation).
        /// </summary>
        /// <param name="configuration">
        /// The preferred configuration  will contains the following sections:
        ///    a) Fiscal header/footer
        ///    b) Tax rates table
        ///    c) Menu Items list (Item PLU, Name, Tax Id, Full item price)
        ///    d) Communication parameters (Com port, baudrate, tcp address, USB params, etc.)
        ///    e) Operation parameters (Print something, not print something else, line width, etc.)
        /// </param>
        /// <returns>Status with an Error Code and a Message</returns>
        Status Init(DeviceInitConfiguration configuration);

        /// <summary>
        ///At the very end of POS application startup and right after device Initialization (see 8.1) such method should be called. Failure to open device should halt POS operations as indicated by Fiscal Laws where device is operating.
        ///start.
        /// </summary>
        /// <returns>Status with an Error Code and a Message</returns>
        Status OpenDevice();

        /// <summary>
        ///Method should be called right before POS application close. This operation will do the required housecleaning (clear all messages sent to line display, close ports, delete buffers, etc.)
        /// </summary>
        /// <returns>Status with an Error Code and a Message</returns>
        Status CloseDevice();

        /// <summary>
        ///Operation will process the day that needs to be opened for business. Failure to open business day should halt POS operations as indicated by Fiscal Laws where device is operating.
        /// </summary>
        /// <param name="businessDate">The Date of the Business Day to Open</param>
        /// <returns>Status with an Error Code and a Message</returns>
        Status OpenBusinessDay(DateTime businessDate);

        /// <summary>
        ///Operation will process the day that needs to be closed for business. Failure to close business day should halt POS operations as indicated by Fiscal Laws where device is operating.    
        /// </summary>
        /// <param name="businessDate">The Date of the Business Day to Open</param>
        /// <returns>Status with an Error Code and a Message</returns>
        Status CloseBusinessDay(DateTime businessDate); 

        /// <summary>
        ///Operation will register and log in the current Cashier / Drawer Operator the first time the drawer is opened to the fiscal device. Failure login cashier should halt POS operations as indicated by Fiscal Laws where device is operating.
        /// </summary>
        /// <param name="POSIndentifier">The unique terminal Identifier</param>
        /// <param name="cashierID">The Cashier that opened the drawer</param>
        /// <param name="cashierName">A Description of the Cashier opening the Drawer</param>
        /// <returns>Status with an Error Code and a Message</returns>
        Status CashierLogin(string POSIndentifier, int cashierID, string cashierName); 

        /// <summary>
        ///Operation will register and log in the current Cashier / Drawer Operator the first time the drawer is opened to the fiscal device. Failure login cashier should halt POS operations as indicated by Fiscal Laws where device is operating.
        /// </summary>
        /// <param name="POSIndentifier">The unique terminal Identifier</param>
        /// <param name="cashierID">The Cashier that opened the drawer</param>
        /// <param name="cashierName">A Description of the Cashier opening the Drawer</param>
        /// <returns>Status with an Error Code and a Message</returns>
        Status CashierLogout(string POSIndentifier, int cashierID, string cashierName);  

        /// <summary>
        ///Operation should be called during any money insertion transaction to the drawer. Failure to process any deposit should halt POS operations as indicated by Fiscal Laws where device is operating. 
        /// </summary>
        /// <param name="POSIndentifier">A unique Identifier for the terminal</param>
        /// <param name="cashierID">The cashier adding money to the drawer</param>
        /// <param name="cashierName">A description of the cashier</param>
        /// <param name="tenderType">Type of tender used in cash in</param>
        /// <param name="amount">amount of deposit</param>
        /// <returns>Status with an Error Code and a Message</returns>
        Status MoneyIn(string POSIndentifier, int cashierID, string cashierName, Tender tenderType, decimal amount); 

        /// <summary>
        ///Operation should be called during any money extraction transaction from the drawer. Failure to process any withdrawal should halt POS operations as indicated by Fiscal Laws where device is operating.
        /// </summary>
        /// <param name="POSIndentifier">A unique Identifier for the terminal</param>
        /// <param name="cashierID">The cashier removing money to the drawer</param>
        /// <param name="cashierName">A description of the cashier</param>
        /// <param name="tenderType">Type of tender used in cash out</param>
        /// <param name="amount">amount of witharawal</param>
        /// <returns>Status with an Error Code and a Message</returns>
        Status MoneyOut(string POSIndentifier, int cashierID, string cashierName, Tender tenderType, decimal amount);

        /// <summary>
        ///Operation will be called to record any fiscal transaction required by law. This includes sales, return by item. Voids should be processed as return by item of entire order to be voided. Failure to process any transaction should halt POS operations as indicated by Fiscal Laws where device is operating.
        /// </summary>
        /// <param name="xmlDocument">XML document with the transaction details.</param>
        /// <returns>Status with an Error Code and a Message</returns>
        FiscalInfoResponseResult RegisterFiscalTransaction(string xmlDocument);

        /// <summary>
        ///Operation should be called to print to Device the requested report. Report types supported are dependent of the fiscal control unit hardware. Failure to print report should halt POS operations as indicated by Fiscal Laws where device is operating.
        /// </summary>
        /// <param name="reportRequest">Represnts the  <see cref="ReportRequest"/> that will specifiy what type of report should be returned from the Fiscal Device</param>
        /// <returns>Status with an Error Code and a Message</returns>
        Status PrintFiscalReport(ReportRequest reportRequest);

        /// <summary>
        ///Operation should be called to print any non-fiscal documents or reports on the fiscal device. Method should use the file buffer for the requested document. Failure to print report should halt POS operations as indicated by Fiscal Laws where device is operating.
        /// </summary>
        /// <param name="lines">Text to print, separated in lines</param>
        /// <returns>Status with an Error Code and a Message</returns>
        Status PrintNonFiscalDocument(IEnumerable<string> lines); 

        /// <summary>
        ///Operation should be called to ping the fiscal device before any critical fiscal operation to inform operator about possible problems. The meaning is to check the presence and connection to the fiscal device before to open a new order in a POS order editor, or before printing a non-fiscal document. Usage can be applied on the POS right before any call that interacts with fiscal device (mainly on recording fiscal transactions, or in certain POS flows before proceeding with device recording). Failure to get device status should halt POS operations as indicated by Fiscal Laws where device is operating.
        /// </summary>
        /// <param name="statusType">The type of status to check for in the Fiscal Control Unit Device</param>
        /// <returns>A response with and error code and a message and if success the data</returns>
        DeviceResponseResult GetDeviceStatus(DeviceStatusType statusType);

        /// <summary>
        ///Operation should be used to cross-reference the internal POS counters against the fiscal device ones. Information returned will include counters and amounts stored during transaction processing (last fiscal receipt number, TAX counters, GT amount, etc). Failure to get a successful response should halt POS operations as indicated by Fiscal Laws where device is operating.
        /// </summary>
        /// <returns>Status with an Error Code and a Message and the data if success</returns>
        FiscalInfoResponseResult GetFiscalInformation(); 

        ///<sumary>
        ///Operation should be called to obtain the internal clock timestamp of the fiscal device.
        /// </sumary>
        /// <returns>The Internal Date and Time of the Fiscal Control Unit Device</returns>
        DateTime GetFiscalTime(); 


        /// <summary>
        ///Operation should send text lines that are to be displayed on Line Display Control connected to Fiscal Device. Failure to display is non-critical and POS can resume operations if necessary.
        /// </summary>
        /// <param name="lines"></param>
        /// <returns>Status with an Error Code and a Message</returns>
        Status LineDisplayOut(IEnumerable<string> lines); 

        /// <summary>
        ///Operation should be used when there’s a need to control physical cash drawer unit openings and it’s directly connected to Fiscal Device.
        /// </summary>
        /// <returns></returns>
        Status OpenCashDrawer();


        /// <summary>
        /// Gets the last error issued by the Fiscal Device
        /// </summary>
        /// <returns>Status with an Error Code and a Message</returns>
        Status GetLastError();

    }
}
