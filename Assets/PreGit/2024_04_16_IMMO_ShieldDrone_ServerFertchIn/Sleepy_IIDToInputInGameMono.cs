using System;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;

public class Sleepy_IIDToInputInGameMono : MonoBehaviour
{
    public string m_text = "";
    public byte[] m_binary;

    public int m_intIndex = 0;
    public int m_intValue = 0;
    public ulong m_utcDateMilliseconds = 0;
    public ulong m_receivedTime = 0;
    public ulong m_sendToReceivedLag = 0;


    public bool m_useFilterFrontDigit;
    public int m_frontalDigit = -16;
    public WaitingQueueOfInputIIDMono m_waitingQueueOfInputIIDMono;


    public UnityEvent<STRUCT_IndexIntegerDateValue> m_onEnqueue;
    //private void Awake()
    //{
    //    m_connection.m_onThreadMessageReceivedBinary += PushBytes;
    //}
    public int m_lastFrontalDigit = 0;
    public ulong m_lastDateReceived;
    public void PushBytes(byte[] receivedBytes)
    {
        m_binary = receivedBytes;
        if (m_binary.Length == 16)
        {
            int value = BitConverter.ToInt32(receivedBytes, 4);
            int frontal = (int)(value / 100000000);
            if(frontal!=0)
                m_lastFrontalDigit = frontal;
            if (m_useFilterFrontDigit && frontal != m_frontalDigit)
                return;
            int index = BitConverter.ToInt32(receivedBytes, 0);

            ulong date = BitConverter.ToUInt64(receivedBytes, 8);
            if (date <= m_lastDateReceived)
                return;
            m_lastDateReceived = date;
            ulong receivedTime = (ulong)DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond;

            m_intIndex = index;
            m_intValue = value;
            m_utcDateMilliseconds = date;
            m_receivedTime = receivedTime;
            m_sendToReceivedLag = m_receivedTime - m_utcDateMilliseconds;
            STRUCT_IndexIntegerDateValue created = new STRUCT_IndexIntegerDateValue()
            {
                m_index = index,
                m_integer = value,
                m_date = date
            };

            m_waitingQueueOfInputIIDMono.Enqueue(created);
            m_onEnqueue.Invoke(created);
        }
    }
}
