﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Result;

namespace BusinessLayer.Abstract
{
    public interface ILeafService
    {
        IResult AddLeaf(Leaf leaf);
        IResult DeleteLeaf(Leaf leaf);
        IResult UpdateLeaf(Leaf leaf);
        IDataResult<List<Leaf>> GetLeaves(Expression<Func<Leaf, bool>> expression=null);
        IDataResult<Leaf> GetLeaf(int leafId);
    }
}
