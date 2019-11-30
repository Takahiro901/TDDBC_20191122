using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDBC_Scheduler;

namespace TDDBC_Scheduler_Test
{
    [TestClass]
    public class SchedulerTest
    {
        private SchedulerSetting defaultSchedulerSetting;
        [TestInitialize]
        public void Initialize()
        {
            defaultSchedulerSetting = new SchedulerSetting("18", "9", "32");
        }
        

        [TestMethod]
        public void 文字列表現を取得する()
        {
            //実行
            string actual = defaultSchedulerSetting.GetTimeString();

            //検証
            Assert.AreEqual("32 9 18", actual);
        }

        [DataTestMethod]
        [DataRow("32", "9", "18")]
        [DataRow("1", "12", "7")]
        [DataRow("0", "0", "0")]
        public void 時刻を与えて設定された時刻と一致する(string a, string b, string c)
        {
            //準備
            var schedulerSetting = new SchedulerSetting(a, b, c);

            //実行
            bool isSame = schedulerSetting.TaskIsExcutable(a, b, c);

            //検証
            Assert.AreEqual(true, isSame);
        }


        [DataTestMethod]
        [DataRow("32", "9", "18")]
        [DataRow("1", "12", "7")]
        [DataRow("0", "0", "0")]
        public void 時刻を与えて設定された時刻と一致しない(string a, string b, string c)
        {
            //実行
            bool isSame = defaultSchedulerSetting.TaskIsExcutable(a, b, c);

            //検証
            Assert.AreEqual(false, isSame);
        }

    }
}