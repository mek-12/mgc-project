using MGC.BLL.Concrete.MCategory;
using MGC.CCC;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGC.BLL.Concrete.MControllerManager.MCategory
{
    public class CategoryControllerManager
    {
        private const string MAC = "mac";
        private const string MIC = "mic";
        private const string C = "c";

        public object GetCategories(string categoryCode)
        {
            try
            {
                var splitCategoryCode = categoryCode.Split('_', 1);
                var code = splitCategoryCode[0];
                var id = splitCategoryCode[1];
                if (code == string.Empty && id == string.Empty)
                    return new CResult<object>() { Message = "Bad property!!!", IsSucceeded = false };

                if (code == MAC)
                {
                    using (var controllerManager = new MiddleCategoryManager())
                    {
                        var list = controllerManager.GetAllIncluding(c => c.Id == Guid.Parse(id));
                        return list.Model;
                    }
                }
                if(code == MIC)
                {
                    using (var controllerManager = new MiddleCategoryManager())
                    {
                        var list = controllerManager.GetAllIncluding(c => c.Id == Guid.Parse(id));
                        return list.Model;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
