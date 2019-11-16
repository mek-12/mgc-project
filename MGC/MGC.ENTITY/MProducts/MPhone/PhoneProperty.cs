using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MGC.ENTITY.MProducts.MPhone
{
    public class PhoneProperty
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Weight { get; set; }
        public string ConnectionSpeed { get; set; }
        public string Dimensions { get; set; }
        public string MainCamera { get; set; }
        public string FrontCamera { get; set; }
        public string ChargingInput { get; set; }
        public int BatteryType { get; set; }
        public string CellularSpeed { get; set; }
        public string TotalTalkTime { get; set; }
        public int WarrantyTime { get; set; }
        public string ScreenType { get; set; }

        public int PhoneBatteryCapacityId { get; set; }
        public int PhoneInternalMemoryId { get; set; }
        public int PhoneScreenDimensionId { get; set; }
        public int PhoneWifiId { get; set; }
        public int PhoneCpuCapacityId { get; set; }
        public int PhoneOSId { get; set; }
        public int PhoneOSTypeId { get; set; }
        public int PhoneRamCapasityId { get; set; }

        public bool DualSIM { get; set; }
        public bool TouchScreen { get; set; }
        public bool ExpandableMemory { get; set; }
        public bool IntegratedCamera { get; set; }
        public bool IntegratedFlash { get; set; }
        public bool EyeScan { get; set; }
        public bool GPS { get; set; }
        public bool WirelessCharging { get; set; }
        public bool NFC { get; set; }
        public bool FaceRecognition { get; set; }
        public bool AbroadSales { get; set; }
        public bool Fingerprint { get; set; }

        [ForeignKey("PhoneId")]
        public Phone Phone { get; set; }
        [ForeignKey("PhoneOSId")]
        public PhoneOS PhoneOS { get; set; }
        [ForeignKey("PhoneOSTypeId")]
        public PhoneOSType PhoneOSType { get; set; }
        [ForeignKey("CpuCapacityId")]
        public PhoneCpuCapacity PhoneCpuCapacity { get; set; }
        [ForeignKey("WifiId")]
        public PhoneWifi PhoneWifi { get; set; }
        [ForeignKey("PhoneRamCapasityId")]
        public PhoneRamCapacity PhoneRamCapacity { get; set; }
        [ForeignKey("PhoneBatteryCapacityId")]
        public PhoneBatteryCapacity PhoneBatteryCapacity { get; set; }
        [ForeignKey("PhoneScreenDimensionId")]
        public PhoneScreenDimension PhoneScreenDimension { get; set; }
        [ForeignKey("PhoneInternalMemoryId")]
        public PhoneInternalMemory PhoneInternalMemory { get; set; }
    }
}
