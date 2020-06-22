/*
 * PTra12_02.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using common;

//※ この問題はcommonのDogクラスを完成させてから実施してください。
public class PTra12_02
{
    public static void Main(string[] args)
    {
        // TODO commonのDogクラスをインスンタンス化してください
        var dogsample = new common.Dog();

        // TODO Dog型インスタンスのnameフィールドに ポチ を代入してください
        dogsample.SetName("ポチ");

        // TODO Dog型インスタンスのRunメソッドを実行してください
        dogsample.Run();
        // ※ ポチは走りました。が表示されれば正解

        // TODO Dog型インスタンスのEatメソッドを実行してください
        dogsample.Eat();
        // ※ ポチはドッグフードを食べました。が表示されれば正解

    }
}
