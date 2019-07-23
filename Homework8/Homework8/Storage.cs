using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework8
{
    abstract public class Storage
    {
        protected string CarrierName { get; set; }
        protected string CarrierModel { get; set; }
        public int CopySpeed { get; set; }
        public int GlobalMemory { get; set; }
        public int OccupiedMemory { get; set; }

        public Storage(string carrierName, string carrierModel, int globalMemory)
        {
            GlobalMemory = globalMemory;
            CarrierModel = carrierModel;
            CarrierName = carrierName;
        }

        public abstract void CopyData(params int[] datas);
        public abstract int GetFreeMemory();
        public abstract void GetInfo();
    }
}