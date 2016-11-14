namespace MvcExperiment.GridMvc.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using MvcExperiment.GridMvc.Enums;
    using MvcExperiment.GridMvc.Models;

    /// <summary>
    /// キャラクタ関連サービス
    /// </summary>
    public class CaractorService
    {
        /// <summary>
        /// 一覧を取得
        /// </summary>
        /// <returns>キャラクタの一覧</returns>
        public static IList<Caractor> GetCaractors()
        {
            var list = new List<Caractor>();
            list.Add(new Caractor(1, "ロミオ", "", CaractorSexCd.Male, CaractorCategoryCd.Cd1));
            list.Add(new Caractor(2, "アルフレド", "", CaractorSexCd.Male, CaractorCategoryCd.Cd1));
            list.Add(new Caractor(3, "ビアンカ", "", CaractorSexCd.Female, CaractorCategoryCd.Cd1));
            list.Add(new Caractor(4, "ジョバンニ", "", CaractorSexCd.Male, CaractorCategoryCd.Cd1));
            list.Add(new Caractor(5, "ムーミン", "", CaractorSexCd.Male, CaractorCategoryCd.Cd2));
            list.Add(new Caractor(6, "フローレン", "", CaractorSexCd.Female, CaractorCategoryCd.Cd2));
            list.Add(new Caractor(7, "ミイ", "", CaractorSexCd.Female, CaractorCategoryCd.Cd2));
            list.Add(new Caractor(8, "スニフ", "", CaractorSexCd.Male, CaractorCategoryCd.Cd2));
            list.Add(new Caractor(9, "スナフキン", "", CaractorSexCd.Male, CaractorCategoryCd.Cd2));
            list.Add(new Caractor(10, "名前10", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(11, "名前11", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(12, "名前12", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(13, "名前13", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(14, "名前14", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(15, "名前15", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(16, "名前16", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(17, "名前17", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(18, "名前18", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(19, "名前19", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(20, "名前20", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(21, "名前21", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(22, "名前22", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(23, "名前23", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(24, "名前24", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(25, "名前25", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(26, "名前26", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(27, "名前27", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(28, "名前28", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(29, "名前29", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(30, "名前30", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(31, "名前31", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(32, "名前32", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(33, "名前33", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(34, "名前34", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(35, "名前35", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(36, "名前36", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(37, "名前37", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(38, "名前38", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(39, "名前39", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(40, "名前40", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(41, "名前41", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(42, "名前42", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(43, "名前43", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(44, "名前44", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(45, "名前45", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(46, "名前46", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(47, "名前47", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(48, "名前48", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(49, "名前49", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(50, "名前50", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(51, "名前51", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(52, "名前52", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(53, "名前53", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(54, "名前54", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(55, "名前55", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(56, "名前56", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(57, "名前57", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(58, "名前58", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(59, "名前59", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(60, "名前60", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(61, "名前61", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(62, "名前62", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(63, "名前63", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(64, "名前64", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(65, "名前65", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(66, "名前66", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(67, "名前67", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(68, "名前68", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(69, "名前69", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(70, "名前70", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(71, "名前71", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(72, "名前72", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(73, "名前73", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(74, "名前74", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(75, "名前75", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(76, "名前76", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(77, "名前77", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(78, "名前78", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(79, "名前79", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(80, "名前80", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(81, "名前81", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(82, "名前82", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(83, "名前83", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(84, "名前84", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(85, "名前85", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(86, "名前86", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(87, "名前87", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(88, "名前88", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(89, "名前89", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(90, "名前90", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(91, "名前91", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(92, "名前92", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(93, "名前93", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(94, "名前94", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(95, "名前95", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(96, "名前96", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(97, "名前97", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(98, "名前98", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(99, "名前99", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));
            list.Add(new Caractor(100, "名前100", "", CaractorSexCd.None, CaractorCategoryCd.Cd0));

            return list;
        }
    }
}