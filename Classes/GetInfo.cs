using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace WorkTesting.Classes
{
    class GetInfo
    {



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string FindMachineSerialNumber()
        {
            string MSerialNumber = "";
            ManagementObjectSearcher Searcher = new ManagementObjectSearcher("Select * From Win32_BIOS");
            foreach(ManagementObject serial in Searcher.Get())
            {
                MSerialNumber = serial["SerialNumber"].ToString();
            }
            return MSerialNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string FindMotherboardSerialNumber()
        {
            string MBSerialNumber = "";
            ManagementObjectSearcher Searcher = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
            foreach (ManagementObject serial in Searcher.Get())
            {
                MBSerialNumber = serial["SerialNumber"].ToString();
            }
            return MBSerialNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string FindProcessorSerialNumber()
        {
            string ProcessorSerialNumber = "";
            ManagementObjectSearcher Searcher = new ManagementObjectSearcher("Select * From Win32_Processor");
            foreach (ManagementObject serial in Searcher.Get())
            {
                ProcessorSerialNumber = serial["SerialNumber"].ToString();
            }
            return ProcessorSerialNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MachineSN"></param>
        /// <param name="MBSN"></param>
        /// <param name="ProcessorSN"></param>
        /// <returns></returns>
        public static int CombineFound()
        {
            string MachineSN = FindMachineSerialNumber();
            string MBSN = FindMotherboardSerialNumber();
            string ProcessorSN = FindProcessorSerialNumber();
            var GUID = (MachineSN.GetHashCode()) ^ (MBSN.GetHashCode()) ^ (ProcessorSN.GetHashCode());
            if (GUID < 0) GUID = GUID * -1;
            return GUID;
        }
    }
}
