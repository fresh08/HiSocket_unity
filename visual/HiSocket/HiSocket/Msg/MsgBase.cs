﻿//****************************************************************************
// Description:
// Author: hiramtan@live.com
//***************************************************************************

namespace HiSocket
{
    public abstract class MsgBase
    {
        public readonly IByteArray ByteArray;

        protected MsgBase(IByteArray byteArray)
        {
            ByteArray = byteArray;
        }

        protected MsgBase()
        {
            ByteArray = new ByteArray();
        }
    }
}