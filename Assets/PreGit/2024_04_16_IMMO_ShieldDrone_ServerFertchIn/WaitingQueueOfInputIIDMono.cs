using UnityEngine;
using System.Collections.Concurrent;

public class WaitingQueueOfInputIIDMono: MonoBehaviour {

    public static ConcurrentQueue<STRUCT_IndexIntegerDateValue> m_waitingInput = new ConcurrentQueue<STRUCT_IndexIntegerDateValue>();
    public int m_inWaitingToBeDequeue;
    public ulong m_enqueueCount;
    public void Enqueue(STRUCT_IndexIntegerDateValue inputKey) {
        m_enqueueCount++;
        m_waitingInput.Enqueue(inputKey);
        m_inWaitingToBeDequeue = m_waitingInput.Count;
    }

    public ConcurrentQueue<STRUCT_IndexIntegerDateValue> GetQueueRef(){ 
        return m_waitingInput; 
    }
}
