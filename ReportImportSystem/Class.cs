using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportImportSystem
{
    class Class
    {
    }

    class Cauthen
    {
        public string service, nsrsbh, nsrmc, license, sequence, timestamp, czlx, sssq_q, sssq_z;

        public string[] name = new string[]
            {"service", "nsrsbh", "nsrmc", "license", "sequence", "timestamp", "czlx", "sssq_q", "sssq_z"};

        public Cauthen()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Service">申报类型</param>
        /// <param name="Nsrsbh">纳税人识别号</param>
        /// <param name="Nsrmc">纳税人名称</param>
        /// <param name="License">授权码</param>
        /// <param name="Sequence">交易流水</param>
        /// <param name="Timestamp">时间戳</param>
        /// <param name="Czlx">操作类型</param>
        /// <param name="Sssq_q">所属期起</param>
        /// <param name="Sssq_z">所属期止</param>
        public Cauthen(string Service, string Nsrsbh, string Nsrmc, string License, string Sequence, string Timestamp,
            string Czlx, string Sssq_q, string Sssq_z)
        {
            service = Service;
            nsrsbh = Nsrsbh;
            nsrmc = Nsrmc;
            license = License;
            sequence = Sequence;
            timestamp = Timestamp;
            czlx = Czlx;
            sssq_q = Sssq_q;
            sssq_z = Sssq_z;
        }

        public string this[int index]
        {
            set
            {
                switch (index)
                {
                    case 0:
                        service = value;
                        break;
                    case 1:
                        nsrsbh = value;
                        break;
                    case 2:
                        nsrmc = value;
                        break;
                    case 3:
                        license = value;
                        break;
                    case 4:
                        sequence = value;
                        break;
                    case 5:
                        timestamp = value;
                        break;
                    case 6:
                        czlx = value;
                        break;
                    case 7:
                        sssq_q = value;
                        break;
                    case 8:
                        sssq_z = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("index");
                }
            }
            get
            {
                switch (index)
                {
                    case 0: return service;
                    case 1: return nsrsbh;
                    case 2: return nsrmc;
                    case 3: return license;
                    case 4: return sequence;
                    case 5: return timestamp;
                    case 6: return czlx;
                    case 7: return sssq_q;
                    case 8: return sssq_z;
                    default:
                        throw new ArgumentOutOfRangeException("index");
                }
            }
        }
    }
}
