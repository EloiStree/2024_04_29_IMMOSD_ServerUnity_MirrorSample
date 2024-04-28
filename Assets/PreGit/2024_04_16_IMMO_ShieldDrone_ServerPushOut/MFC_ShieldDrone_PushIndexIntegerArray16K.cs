//using DroneIMMO;
//using Eloi.WatchAndDate;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using Unity.Collections;
//using UnityEngine;

//public class MFC_ShieldDrone_PushIndexIntegerArray16K : MonoBehaviour
//{
//    public MFC_PushLargeBytesWithDateUpdate m_memoryPusher;
//    public SNAM16K_ObjectInt m_claimIndexByIntegerPlayer;
//    public WatchAndDateTimeActionResult m_pushTiming;
//    public int[] m_dataInt = new int[IMMO16K.ARRAY_MAX_SIZE ];
//    public byte[] m_dataByte = new byte[IMMO16K.ARRAY_MAX_SIZE * 4];

//    [ContextMenu("Push")]
//    public void Push()
//    {

//        m_pushTiming.StartCounting();
//        NativeArray<int> indexArray = m_claimIndexByIntegerPlayer.GetNativeArray();
//        indexArray.CopyTo(m_dataInt);
//        Buffer.BlockCopy(m_dataInt,0, m_dataByte, 0,m_dataByte.Length);
//        m_memoryPusher.PushBytes(m_dataByte);
//        m_pushTiming.StopCounting();
//    }
//}