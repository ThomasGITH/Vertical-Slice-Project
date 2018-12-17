using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JsonFormat
{
    public interface IData { }

    public enum Datatype
    {
        CHAR_DATA, TEST_DATA
    }
    
    public struct CharacterData : IData
    {
        public uint hairstyle;
        public uint skincolor;
    }

    public struct TestData : IData
    {
        public uint beep;
        public uint boop;
    }

    public struct MonoData : IData
    {
        public uint noop;
        public uint yaap;
    }
}