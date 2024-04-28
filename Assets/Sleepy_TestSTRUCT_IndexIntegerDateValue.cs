using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleepy_TestSTRUCT_IndexIntegerDateValue : MonoBehaviour
{
    public AA a = new AA();
    [System.Serializable]
    public class AA : Eloi.GenericClampHistory<STRUCT_IndexIntegerDateValue> { }
    // Start is called before the first frame update
    public void PushIn(STRUCT_IndexIntegerDateValue value)
    {
        a.PushIn(value);     
    }

}
