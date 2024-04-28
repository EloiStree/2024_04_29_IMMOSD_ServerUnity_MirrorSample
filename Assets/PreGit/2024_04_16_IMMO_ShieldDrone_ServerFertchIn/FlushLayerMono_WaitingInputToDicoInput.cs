// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class FlushLayerMono_WaitingInputToDicoInput : MonoBehaviour
// {

//     public WaitingQueueOfInputIIDMono m_waitingQueue;
//     public DicoClaimToSNAMIndexClaimMono m_dicoOfPlayer;

//     public bool m_useUpdate;
//     public int m_leftInQueue;
//     void Update()
//     {
//         if(m_useUpdate)
//          FlushQueue();

//     }

//     [ContextMenu("Flush Queue")]
//     public void FlushQueue()
//     {
//         for (int i = 0; i < WaitingQueueOfInputIIDMono.m_waitingInput.Count; i++)
//         {
//             if (WaitingQueueOfInputIIDMono.m_waitingInput.TryDequeue(out STRUCT_IndexIntegerDateValue value))
//             {
//                 m_dicoOfPlayer.SetOrAddFromIntegerindex(value.m_index, value.m_integer);
//             }
//         }
//         m_leftInQueue = WaitingQueueOfInputIIDMono.m_waitingInput.Count;
//     }
// }
