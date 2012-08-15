﻿using System.Linq.Expressions;

namespace StarryEyes.Mystique.Filters.Core.Expressions.Values
{
    public abstract class ValueBase
    {
        public abstract KQExpressionType[] TransformableTypes { get; }

        public abstract Expression GetExpressionFor(KQExpressionType type);

        public abstract string ToQuery();
    }
}