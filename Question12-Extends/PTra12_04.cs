/*
 * PTra12_04.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using common;
using Question12_Extends.common;

public class PTra12_04
{
    /* 
     * TODO common内にCharacterクラスを継承した、Slimeクラスを作成してください
  	 * ●HP, POWER, ENDURANCEはそれぞれ、（10, 5, 2）
  	 */

    public static void Main(string[] args)
    {
        // TODO Slimeクラスをインスンタンス化してください
        var slimesample = new Slime();

        // TODO Slimeインスタンスのnameフィールドに スライム を設定して下さい
        slimesample.SetName("スライム");

        // TODO Slimeインスタンスのキャラクター情報を表示してください
        Console.WriteLine(slimesample.ShowParameter());
    }
}
