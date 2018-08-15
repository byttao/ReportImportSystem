using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ReportImportSystem
{
    class Func
    {
        /// <summary>
        /// 组装上传主体
        /// </summary>
        /// <param name="EnvelopeStr">申报表主体</param>
        /// <param name="CjbbxmlStr">报表部分</param>
        /// <returns>返回上传主体</returns>
        public static string ProduceBody(string EnvelopeStr,string CjbbxmlStr)
        {
            return EnvelopeStr.Substring(0,EnvelopeStr.IndexOf("</cjbbxml>") ) + CjbbxmlStr + EnvelopeStr.Substring(EnvelopeStr.IndexOf("</cjbbxml>"),EnvelopeStr.Length - EnvelopeStr.IndexOf("</cjbbxml>"));
        }
        public static string Escape(string OriginalStr)
        {
            return OriginalStr.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;").Replace("'", "&apos;");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="XDEnvelope"></param>
        /// <param name="service"></param>
        /// <param name="nsrsbh"></param>
        /// <param name="nsrmc"></param>
        /// <param name="license"></param>
        /// <param name="sequence"></param>
        /// <param name="timestamp"></param>
        /// <param name="czlx"></param>
        /// <param name="sssq_q"></param>
        /// <param name="sssq_z"></param>
        /// <returns></returns>
        public static string ProduceEnvelopeBody(XDocument XDEnvelope, string service, string nsrsbh, string nsrmc, string license, string sequence, string timestamp, string czlx, string sssq_q, string sssq_z)
        {
            XElement XEauthen = XDEnvelope.Element("envelope").Element("header").Element("authen");
            XEauthen.Element("service").SetValue(service);
            return "";
        }
        /// <summary>
        /// 上传申报
        /// </summary>
        /// <param name="SBLX">申报类型</param>
        /// <returns>申报结果</returns>
        public static string Upload(string SBLX)
        {

            string envelopeStr, CjbbxmlStr;
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"template\envelope.xml", Encoding.UTF8))
            {
                envelopeStr = sr.ReadToEnd().ToString();
                sr.Close();
            }
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"template\"+SBLX+".xml", Encoding.GetEncoding("gb2312")))
            {
                CjbbxmlStr = sr.ReadToEnd().ToString();
                sr.Close();
            }
            cwxxWsService.CwxxWsServiceClient rxw = new cwxxWsService.CwxxWsServiceClient();
            string result =rxw.receiveXmlWebservice(ProduceBody(envelopeStr , CjbbxmlStr));
            return result;
        }
    }
}
