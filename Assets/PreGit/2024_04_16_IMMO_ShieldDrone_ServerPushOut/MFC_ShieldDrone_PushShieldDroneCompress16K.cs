//using Eloi.WatchAndDate;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class MFC_ShieldDrone_PushShieldDroneCompress16K : MonoBehaviour
//{
//    public MFC_PushLargeBytesWithDateUpdate m_memoryPusher;
//    public BigByteArrayCompressedDrone16KMono m_bigByteArray;
//    public WatchAndDateTimeActionResult m_pushTiming;

//    [ContextMenu("Push")]
//    public void Push()
//    {

//        m_pushTiming.StartCounting();
//        m_memoryPusher.PushBytes(m_bigByteArray.GetBytesArray());
//        m_pushTiming.StopCounting();
//    }
//}