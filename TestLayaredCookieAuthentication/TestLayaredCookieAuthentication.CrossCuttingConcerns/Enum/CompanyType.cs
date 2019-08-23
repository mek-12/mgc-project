using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestLayaredCookieAuthentication.CrossCuttingConcerns.Enum
{
    public enum CompanyType
    {
        [Display(Name="Şahıs Firması")]
        Sahis = 1,
        [Display(Name ="Limited / Anonim Şirketi")]
        Limited = 2,
        [Display(Name ="Serbest Meslek Erbabı")]
        Freelance =3
    }

    public enum RegistrationNoteBookType
    {
        [Display(Name ="Bilanço")]
        Balance = 1,    
        [Display(Name ="Basit Usul")]
        SimpleReigst = 2,
        [Display(Name ="İşletme Defteri")]
        OperatingLedger = 3
    }
}
