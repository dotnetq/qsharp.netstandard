//
//   Copyright (c) 2011-2014 Exxeleron GmbH
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//

using System;
using System.Collections.Generic;

namespace qSharp
{
    /// <summary>
    ///     Enumerates all supported q types.
    /// </summary>
    public enum QType
    {
        NullItem = 101,
        Error = -128,
        GeneralList = 0,
        Bool = -1,
        BoolList = 1,
        Guid = -2,
        GuidList = 2,
        Byte = -4,
        ByteList = 4,
        Short = -5,
        ShortList = 5,
        Int = -6,
        IntList = 6,
        Long = -7,
        LongList = 7,
        Float = -8,
        FloatList = 8,
        Double = -9,
        DoubleList = 9,
        Char = -10,
        String = 10,
        Symbol = -11,
        SymbolList = 11,
        Timestamp = -12,
        TimestampList = 12,
        Month = -13,
        MonthList = 13,
        Date = -14,
        DateList = 14,
        Datetime = -15,
        DatetimeList = 15,
        Timespan = -16,
        TimespanList = 16,
        Minute = -17,
        MinuteList = 17,
        Second = -18,
        SecondList = 18,
        Time = -19,
        TimeList = 19,
        Table = 98,
        KeyedTable = 99,
        Dictionary = 99,
        Lambda = 100,
        LambdaPart = 104,
        Projection = 104,
        UnaryPrimitiveFunc = 101,
        BinaryPrimitiveFunc = 102,
        TernaryOperatorFunc = 103,
        CompositionFunc = 105,
        AdverbFunc106 = 106,
        AdverbFunc107 = 107,
        AdverbFunc108 = 108,
        AdverbFunc109 = 109,
        AdverbFunc110 = 110,
        AdverbFunc111 = 111
    }
}