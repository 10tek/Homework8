using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class HDD : Storage
    {
        public HDD(string carrierName, string carrierModel, int globalMemory) : base(carrierName, carrierModel, globalMemory)
        {
            CopySpeed = Constants.USB_2_0_SPEED;
        }

        public override void CopyData(params int[] datas)
        {
            for (int i = 0; i < datas.Length; i++)
            {
                if (OccupiedMemory + datas[i] < GlobalMemory)
                {
                    OccupiedMemory += datas[i];
                }
                else
                {
                    Console.WriteLine("Объем памяти переполнен!");
                }
            }
        }

        public override int GetFreeMemory()
        {
            return GlobalMemory - OccupiedMemory;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Имя: {CarrierName};\nМодель: {CarrierModel};\nСкорость копирования: {CopySpeed} МБ/сек;\nОбъем памяти: {GlobalMemory}МБ;\nЗанято: {OccupiedMemory}МБ;\nСвободно: {GetFreeMemory()}МБ;");
        }
    }
}
