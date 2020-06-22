/*
 * PTra12_07.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using common;
using Question12_Extends.common;

public class PTra12_07
{
    /*
  	 * 作成した、SuperHero、Slimeクラスを使用します
  	 */
    public static void Main(string[] args)
    {
        // TODO SuperHeroインスタンスとSlimeインスタンスを作成し、それぞれの名前に"勇者(装備あり)", "スライム"を設定してください
        var superherosample = new SuperHero();
        superherosample.SetName("勇者(装備あり)");
        var slimesample = new Slime();
        slimesample.SetName("スライム");

        // TODO Itemクラスのインスタンスを作成し、(ロングソード", 20）をコンストラクタの引数にしてください
        var longsoad = new Item("ロングソード", 20);

        // TODO SuperHeroインスンタンスのitemフィールドに作成したitemインスタンスをセットしてください
        superherosample.item = longsoad;

        /*
    	 * TODO SuperHeroとSlimeを、どちらかが体力０になるまで戦わせます
    	 *
    	 * 	●SuperHeroの攻撃 -> ダメージ判定 -> Slimeの攻撃 -> ダメージ判定
    	 * 上記を繰り返し行います
    	 *
    	 * 戦闘が終了したら、勝利した方の出力を行ってください。「○○は■■との戦闘に勝利した」
    	 */
        while (true)
        {
            slimesample.Damage(superherosample.Attack());
            if (slimesample.hp == 0)
            {
                Console.WriteLine("勇者はスライムとの戦闘に勝利した");
                break;
            }
            superherosample.Damage(slimesample.Attack());
            if (superherosample.hp == 0)
            {
                Console.WriteLine("スライムは勇者との戦闘に勝利した");
                break;
            }
        }
    }
}
