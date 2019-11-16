using MGC.BLL.Abstract.MCategory;
using MGC.CCC;
using MGC.ENTITY.MCategory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGC.BLL.Concrete.MCategory
{
    public class MiddleCategoryManager : BaseManager<MiddleCategory>, IMiddleCategoryManager, IDisposable
    {
        public CResult<IList<MiddleCategory>> GetMiddleCategoryFromMainId(Guid mainCategoryId)
        {
            try
            {
                var middleCategories = this.GetListWithCondition(c => c.MainCategoryId == mainCategoryId);
                return middleCategories;
            }
            catch (Exception ex)
            {
                return new CResult<IList<MiddleCategory>>()
                {
                    IsSucceeded = false,
                    Message = ex.Message,
                    Model = null
                };
            }
        }

        public CResult<IList<MiddleCategory>> GetMiddleCategortFromMiddleId(Guid middleCategoryId)
        {
            try
            {
                var middleCategories = this.GetListWithCondition(c => c.MiddleCategoryId == middleCategoryId);
                return middleCategories;
            }
            catch (Exception ex)
            {
                return new CResult<IList<MiddleCategory>>()
                {
                    IsSucceeded = false,
                    Message = ex.Message,
                    Model = null
                };
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
