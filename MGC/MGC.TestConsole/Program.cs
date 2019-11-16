using MGC.BLL.Abstract.MCategory;
using MGC.BLL.Concrete.MCategory;
using MGC.DAL.Abstract.MIdentity;
using MGC.DAL.Concrete.EFCore;
using MGC.DAL.Concrete.MIdentity;
using MGC.ENTITY.MCategory;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MGC.TestConsole
{
    /*public class DistrictInfo
    {
        public string il { get; set; }
        public int plaka { get; set; }
        public List<string> ilceleri { get; set; }
    }*/

    public class Program
    {
        static void Main(string[] args)
        {
            /*Type computerType2 = Type.GetType("MGC.ENTITY.Identity.ApplicationUser,MGC.ENTITY");
            var repository = (IRepositoryFilter)GeneratorRepository.GetRepositoryFromEntityType(computerType2);

            var list = repository.GetAllAsList();
            
            Console.WriteLine(list);
            

            Console.WriteLine(repository);
            Console.WriteLine(computerType2);*/


            /*Repository<District> context = new Repository<District>();
            using (StreamReader sr = new StreamReader(@"D:\Projects\Web\mgc-project\MGC\MGC.TestConsole\json1.json"))
            {
                var json = sr.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<DistrictInfo>>(json);

                foreach (var item in items)
                {
                    
                    foreach (var ilce in item.ilceleri)
                    {
                        District district = new District();
                        district.Name = ilce;
                        district.ProvinceId = item.plaka;
                        context.Add(district);
                    }
                    Console.WriteLine(item);
                }
            }*/

            /*IUserDal userDal = new UserDal();

            var id = Guid.Parse("84df66ca-2c9c-4599-930b-78129f1c1fe1");

            var entity = userDal.Get(id).Model;

            userDal.Delete(entity);*/

            IMiddleCategoryManager categoryManager = new MiddleCategoryManager();

            var list = new List<MiddleCategory>()
            {
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7533F701-4027-4234-8526-1636847AD3E8"),Name="Notebook"},  
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7533F701-4027-4234-8526-1636847AD3E8"),Name="Oyun Bilgisayarı"},  
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7533F701-4027-4234-8526-1636847AD3E8"),Name="İkisi Bir Arada"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("2102CD55-21C8-4230-B2CC-CD1485B138C6"),Name="All-In-One"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("2102CD55-21C8-4230-B2CC-CD1485B138C6"),Name="Masaüstü Bilgisayar"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("2102CD55-21C8-4230-B2CC-CD1485B138C6"),Name="Anakart"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7A8722D5-B746-4E0B-97D0-BEC1710ED9BB"),Name="Ekran Kartı"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7A8722D5-B746-4E0B-97D0-BEC1710ED9BB"),Name="Ram"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7A8722D5-B746-4E0B-97D0-BEC1710ED9BB"),Name="İşlemciler"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7A8722D5-B746-4E0B-97D0-BEC1710ED9BB"),Name="Disk"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7A8722D5-B746-4E0B-97D0-BEC1710ED9BB"),Name="HDD", IsVisible = false},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7A8722D5-B746-4E0B-97D0-BEC1710ED9BB"),Name="SSD", IsVisible = false},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7A8722D5-B746-4E0B-97D0-BEC1710ED9BB"),Name="Optik Sürücü" , IsVisible = false},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7A8722D5-B746-4E0B-97D0-BEC1710ED9BB"),Name="Soğutucular", IsVisible = false},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7A8722D5-B746-4E0B-97D0-BEC1710ED9BB"),Name="Sunucu Donanımları", IsVisible = false},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("7A8722D5-B746-4E0B-97D0-BEC1710ED9BB"),Name="Kasa"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("30F31360-DB90-4C19-A158-910163A774EA"),Name="Oyun Bilgisayarı"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("30F31360-DB90-4C19-A158-910163A774EA"),Name="Oyun Donanımları"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("30F31360-DB90-4C19-A158-910163A774EA"),Name="Klavye"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("30F31360-DB90-4C19-A158-910163A774EA"),Name="Mouse"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("30F31360-DB90-4C19-A158-910163A774EA"),Name="Kulaklık"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("30F31360-DB90-4C19-A158-910163A774EA"),Name="Monitor"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("133306AD-B51F-4F97-B87C-CFB7C3CC0B97"),Name="Mouse"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("133306AD-B51F-4F97-B87C-CFB7C3CC0B97"),Name="Klavye"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("133306AD-B51F-4F97-B87C-CFB7C3CC0B97"),Name="Monitor"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("133306AD-B51F-4F97-B87C-CFB7C3CC0B97"),Name="Yazıcı"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("04FE15FE-30A3-4AC0-8EB4-9583F084997D"),Name="Antivirüs & Güvenlik"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("04FE15FE-30A3-4AC0-8EB4-9583F084997D"),Name="Oyun"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("04FE15FE-30A3-4AC0-8EB4-9583F084997D"),Name="Office"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("04FE15FE-30A3-4AC0-8EB4-9583F084997D"),Name="Eğitim"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("04FE15FE-30A3-4AC0-8EB4-9583F084997D"),Name="İşletim Sistemleri"},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("04FE15FE-30A3-4AC0-8EB4-9583F084997D"),Name="Çeviri & Sözlük" ,IsVisible= false},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("04FE15FE-30A3-4AC0-8EB4-9583F084997D"),Name="Tasarım", IsVisible=false},
                new MiddleCategory(){MiddleCategoryId= Guid.Parse("04FE15FE-30A3-4AC0-8EB4-9583F084997D"),Name="Ticari", IsVisible=false}
                //new MiddleCategory(){MiddleCategoryId= Guid.Parse(""),Name=""},
            };

            foreach (var item in list)
            {
                categoryManager.Add(item);
            }
        }
    }
}
