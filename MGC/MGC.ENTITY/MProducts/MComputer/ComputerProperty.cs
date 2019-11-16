using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class ComputerProperty
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        public int MemorySlot { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public int ComputerCache { get; set; }

        public int ComputerRamSpeedId { get; set; }
        [Required]
        public int ComputerScreenSizeId { get; set; }
        [Required]
        public int ComputerScreenCardTypeId { get; set; }
        [Required]
        public int ComputerScreenCardRamId { get; set; }
        [Required]
        public int ComputerScreenCardId { get; set; }
        [Required]
        public int ComputerHDDCapacityId { get; set; }
        [Required]
        public int ComputerSSDCapacityId { get; set; }
        [Required]
        public int ComputerCPUTypeId { get; set; }
        [Required]
        public int ComputerCPUId { get; set; }

        public bool HaveEthernet { get; set; }
        public bool HaveBluetooth { get; set; }
        public bool HaveTouchScreen { get; set; }
        public bool HaveHDMI { get; set; }
        public bool HaveCardReader { get; set; }
        public bool HaveUSB3 { get; set; }
        public bool HaveUSB31 { get; set; }
        public bool HaveWebCam { get; set; }
        public bool HaveOpticalDriver { get; set; }
        public bool HaveOS { get; set; }

        public ComputerCPU ComputerCPU { get; set; }
        [ForeignKey("ComputerCPUTypeId")]
        public ComputerCPUType ComputerCPUType { get; set; }
        [ForeignKey("ComputerSSDCapacityId")]
        public ComputerSSDCapacity ComputerSSDCapacity { get; set; }
        [ForeignKey("ComputerHDDCapacityId")]
        public ComputerHDDCapacity ComputerHDDCapacity { get; set; }
        [ForeignKey("ComputerScreenCardId")]
        public ComputerScreenCard ComputerScreenCard { get; set; }
        [ForeignKey("ComputerScreenCardRamId")]
        public ComputerScreenCardRam ComputerScreenCardRam { get; set; }
        [ForeignKey("ComputerScreenCardTypeId")]
        public ComputerScreenCardType ComputerScreenCardType { get; set; }
        [ForeignKey("ComputerScreenSizeId")]
        public ComputerScreenSize ComputerScreenSize { get; set; }
        [ForeignKey("ComputerRamSpeedId")]
        public ComputerRamSpeed ComputerRamSpeed { get; set; }
        [ForeignKey("ComputerId")]
        public Computer Computer { get; set; }
    }
}
