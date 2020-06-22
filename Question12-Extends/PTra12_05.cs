/*
 * PTra12_05.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using common;
using Question12_Extends.common;

public class PTra12_05
{
    /*
  	 * 作成した、Hero、Slimeクラスを使用します
  	 */
    public static void Main(string[] args)
    {
        // TODO HeroインスタンスとSlimeインスタンスを作成し、それぞれの名前に"勇者", "スライム"を設定してください

        var herosample = new Hero();
        var slimesample = new Slime();
        herosample.SetName("勇者");
        slimesample.SetName("スライム");

        /*
    	 * TODO HeroとSlimeを、どちらかが体力０になるまで戦わせます
    	 *
    	 * 	●Heroの攻撃 -> ダメージ判定 -> Slimeの攻撃 -> ダメージ判定
    	 * 上記を繰り返し行います
    	 *
    	 * 戦いが終了したら、勝利した方の出力を行ってください。「○○は■■との戦闘に勝利した」
    	 */
        while (true)
        {
            slimesample.Damage(herosample.Attack());
            if (slimesample.hp ==0)
            {
                Console.WriteLine("勇者はスライムとの戦闘に勝利した");
                break;
            }
            herosample.Damage(slimesample.Attack());
            if (herosample.hp == 0)
            {
                Console.WriteLine("スライムは勇者との戦闘に勝利した");
                break;
            }
        }
    }
}
