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
        /// <summary>
        /// 字符转义
        /// </summary>
        /// <param name="OriginalStr"></param>
        /// <returns></returns>
        public static string Escape(string OriginalStr)
        {
            return OriginalStr.Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;").Replace("'", "&apos;");
                //.Replace("&", "&amp;")
        }
        /// <summary>
        /// 生成主体文档
        /// </summary>
        /// <param name="XDEnvelope">主体文档</param>
        /// <param name="cauthen">参数</param>
        public static void ProduceEnvelopeBody(ref XDocument XDEnvelope, Cauthen cauthen)
        {
            XElement XEauthen = XDEnvelope.Element("envelope").Element("header").Element("authen");
            for (int i = 0; i < 6; i++)
            {
                XEauthen.Element(cauthen.name[i]).SetValue(cauthen[i]);
            }
            XEauthen= XDEnvelope.Element("envelope").Element("body").Element("logic");
            for (int i = 6; i <= 8; i++)
            {
                XEauthen.Element(cauthen.name[i]).SetValue(cauthen[i]);
            }

            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"template\" + cauthen.service + ".xml", Encoding.GetEncoding("gb2312")))
            {
                XDEnvelope.Element("envelope").Element("body").Element("logic").Element("cjbbxml").SetValue(sr.ReadToEnd());
                sr.Close();
            }
        }

        public static void ProduceReportBody(ref XDocument XDReport,string SBLX,Cauthen cauthen, List<List<string>> zcfzb, List<List<string>> lrb)
        {
            XNamespace xNamespace = "http://www.chinatax.gov.cn/dataspec/";
            XElement xElement = XDReport.Element(xNamespace+"taxML").Element(xNamespace + "syxqyzcfzb").Element(xNamespace + "nsrxxForm1");
            xElement.Element(xNamespace + "nsrsbh").SetValue(cauthen.nsrsbh);
            xElement.Element(xNamespace + "nsrmc").SetValue(cauthen.nsrmc);
            xElement.Element(xNamespace + "bsrq").SetValue(DateTime.Now.ToString("yyyy-MM-dd"));
            xElement.Element(xNamespace + "skssqq").SetValue(cauthen.sssq_q);
            xElement.Element(xNamespace + "skssqz").SetValue(cauthen.sssq_z);
            foreach (var xqyzcfzbGridlb in XDReport.Element(xNamespace + "taxML").Element(xNamespace + "syxqyzcfzb").Element(xNamespace + "syxqyzcfzbGrid").Elements())
            {
                int i = int.Parse(xqyzcfzbGridlb.Element(xNamespace + "ewbhxh").Value);
                if (zcfzb[i-1][1]!="")
                {
                    xqyzcfzbGridlb.Element(xNamespace + "qmyeZc").SetValue(zcfzb[i - 1][2]);
                    xqyzcfzbGridlb.Element(xNamespace + "ncyeZc").SetValue(zcfzb[i - 1][3]);
                }
                if (zcfzb[i - 1][4] != "")
                {
                    xqyzcfzbGridlb.Element(xNamespace + "qmyeQy").SetValue(zcfzb[i - 1][5]);
                    xqyzcfzbGridlb.Element(xNamespace + "ncyeQy").SetValue(zcfzb[i - 1][6]);
                }
            }
            xElement = XDReport.Element(xNamespace + "taxML").Element(xNamespace + "syxqylrb").Element(xNamespace + "nsrxxForm2");
            xElement.Element(xNamespace + "nsrsbh").SetValue(cauthen.nsrsbh);
            xElement.Element(xNamespace + "nsrmc").SetValue(cauthen.nsrmc);
            xElement.Element(xNamespace + "bsrq").SetValue(DateTime.Now.ToString("yyyy-MM-dd"));
            xElement.Element(xNamespace + "skssqq").SetValue(cauthen.sssq_q);
            xElement.Element(xNamespace + "skssqz").SetValue(cauthen.sssq_z);
            foreach (var syxqylrbGrid in XDReport.Element(xNamespace + "taxML").Element(xNamespace + "syxqylrb").Element(xNamespace + "syxqylrbGrid").Elements())
            {
                int i = int.Parse(syxqylrbGrid.Element(xNamespace + "ewbhxh").Value);
                if (lrb[i - 1][1] != "")
                {
                    syxqylrbGrid.Element(xNamespace + "bnljje").SetValue(lrb[i - 1][2]);
                    syxqylrbGrid.Element(xNamespace + "byje").SetValue(lrb[i - 1][3]);
                }
            }
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
            //string result = rxw.receiveXmlWebservice(ProduceBody(envelopeStr, CjbbxmlStr));
            string result = rxw.receiveXmlWebservice(envelopeStr);
            return result;
            //return envelopeStr;
        }
    }
}
