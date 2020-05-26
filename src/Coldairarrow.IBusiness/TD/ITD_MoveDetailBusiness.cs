﻿using Coldairarrow.Entity.TD;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coldairarrow.Business.TD
{
    public interface ITD_MoveDetailBusiness
    {
        Task<PageResult<TD_MoveDetail>> GetDataListAsync(PageInput<ConditionDTO> input);
        Task<List<TD_MoveDetail>> GetDataListAsync(List<string> ids);
        Task<TD_MoveDetail> GetTheDataAsync(string id);
        Task AddDataAsync(TD_MoveDetail data);
        Task UpdateDataAsync(TD_MoveDetail data);
        Task DeleteDataAsync(List<string> ids);
    }
}