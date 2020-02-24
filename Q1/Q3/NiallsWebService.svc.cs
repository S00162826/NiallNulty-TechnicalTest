using Q3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace Q3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NiallsWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NiallsWebService.svc or NiallsWebService.svc.cs at the Solution Explorer and start debugging.
    public class NiallsWebService : INiallsWebService
    {
        public StatusModel DisplayResults()
        {
            //used later to find quotes in XML
            string quote = "'";

            var status = new StatusModel()
            {
                //initial result is set to zero
                statusResultA = 0
             };

            XmlDocument correctDoc = new XmlDocument();
            XmlDocument aDoc = new XmlDocument();
            XmlDocument bDoc = new XmlDocument();
            XmlDocument cDoc = new XmlDocument();

            //loading in correct xml file
            correctDoc.Load("C:/Users/nnult/Desktop/NiallNulty-TechnicalTest/Q1/Q3/CorrectFile.xml");

            //loading in xml file A
            aDoc.Load("C:/Users/nnult/Desktop/NiallNulty-TechnicalTest/Q1/Q3/fileA.xml");

            //loading in xml file B
            bDoc.Load("C:/Users/nnult/Desktop/NiallNulty-TechnicalTest/Q1/Q3/fileB.xml");

            //loading in xml file C
            cDoc.LoadXml(@"<InputDocument>
                                  <DeclarationList>
		                                   <Declaration Command='DEFAULT' Version='5.13'>
                                            <DeclarationHeader>
                                              <Jurisdiction>IE</Jurisdiction>
                                               <CWProcedure>IMPORT</CWProcedure>
                                                   <DeclarationDestination>CUSTOMSWAREIE</DeclarationDestination>
                                                    <DocumentRef>71Q0019681</DocumentRef>
                                     <SiteID>'DUB'</SiteID>
                             <AccountCode>G0779837</AccountCode>
                             </DeclarationHeader>
                            </Declaration>
                             </DeclarationList>
                                </InputDocument>");

            XmlNode b = bDoc.SelectSingleNode("/InputDocument/DeclarationList/Declaration/@Command");

            //getting speecific node to check
            XmlNode c = cDoc.SelectSingleNode("/InputDocument/DeclarationList/Declaration/DeclarationHeader/SiteID");

            //if fileA matches the correct document, 0 is returned
            if (aDoc.Value == correctDoc.Value)
            {
                status.statusResultA = 0;
            }

            //if file contains '', -1 is returned
            if (b.OuterXml.ToString().Equals("Command='DEFAULT'"))
            {
                status.statusResultB = -1;
            }

            //if file SiteID contains '', -2 is returned
            if (c.InnerText.StartsWith(quote) && cDoc.InnerText.EndsWith(quote))
            {
                status.statusResultC = -2; ;
            }

            return status;
        }
    }
}
