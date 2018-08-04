﻿using System;
using Csla;
using System.Collections.Generic;
using System.Linq;

namespace MobileKidsIdApp.Models
{
    [Serializable]
    public class FileReferenceList : BusinessListBase<FileReferenceList, FileReference>
    {
        protected override FileReference AddNewCore()
        {
            var nextId = 0;
            if (this.Count > 0)
            {
                nextId = this.Max(fr => fr.Id) + 1;
            }

            var result = DataPortal.CreateChild<FileReference>();
            result.Id = nextId;
            return result;
        }

        private void Child_Fetch(List<DataAccess.DataModels.FileReference> list)
        {
            foreach (var item in list)
                Add(DataPortal.FetchChild<FileReference>(item));
        }
    }
}