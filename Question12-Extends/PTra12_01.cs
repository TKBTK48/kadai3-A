/*
 * PTra12_01.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using common;

//※ この問題はcommonのCatクラスを完成させてから実施してください。
public class PTra12_01
{
    public static void Main(string[] args)
    {
        // TODO commonのCatクラスをインスンタンス化してください
        var catsample = new common.Cat();

        // TODO Cat型インスタンスのnameフィールドに タマ を代入してください
        catsample.SetName("タマ");

        // TODO Cat型インスタンスのRunメソッドを実行してください
        catsample.Run();
        // ※ タマは走りました。が表示されれば正解

        // TODO Cat型インスタンスのEatメソッドを実行してください
        catsample.Eat();
        // ※ タマは食事をしました。が表示されれば正解

    }
}
