﻿using Coldairarrow.Entity.TD;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coldairarrow.Business.TD
{
    public partial interface ITD_InStorageBusiness
    {
        Task<PageResult<TD_InStorage>> GetDataListAsync(TD_InStoragePageInput input);
    }
}