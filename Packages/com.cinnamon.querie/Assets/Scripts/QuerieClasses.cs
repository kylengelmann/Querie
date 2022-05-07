using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Querie;

[assembly: QuerieElementClass(typeof(QuerieGeneratorBase), typeof(QuerieResultBase))]
[assembly: QuerieElementClass(typeof(QuerieTestBase), typeof(QuerieResultBase))]

namespace Querie
{
    [System.Serializable]
    public abstract class QuerieGeneratorBase
    {
        public abstract void Generate(QuerieResultBase results);
    }

    public abstract class QuerieResultBase
    {

    }

    [System.Serializable]
    public abstract class QuerieTestBase
    {
        public abstract void Test(QuerieResultBase results);
    }
}
