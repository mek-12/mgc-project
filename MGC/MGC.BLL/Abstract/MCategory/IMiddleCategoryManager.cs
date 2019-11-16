using MGC.CCC;
using MGC.ENTITY.MCategory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGC.BLL.Abstract.MCategory
{
    public interface IMiddleCategoryManager : IBaseManager<MiddleCategory>
    {
        CResult<IList<MiddleCategory>> GetMiddleCategoryFromMainId(Guid mainCategoryId);
        CResult<IList<MiddleCategory>> GetMiddleCategortFromMiddleId(Guid middleCategoryId);
    }
}
