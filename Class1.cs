using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace StructAllforTest
{
    [Serializable]
    public struct TestSendStruct
    {
        public string name;
        public string fre;
        public string ab;
        public string cd;

    }

    [Serializable]
    public struct Test2SendStruct
    {
        public string name;
        public string fre;
        public string ab;
        public string cd;
        public int count;
        public int count2;
    }

    [Serializable]
    public struct Test3SendStruct
    {
        public string name;
        public string fre;
        public string ab;
        public string cd;

    }

    [Serializable]
    public struct Test4SendStruct
    {
        public string name;
        public string fre;
        public string ab;
        public string cd;
        public int[] count2;

    }

    public class TestStruct
    {


    }

    [Serializable]

    public class MMS: EventSubscriptionInterface
    {
        #region События
        public delegate void SignalFormedMetaClassMethod(MMS mS);
        public event SignalFormedMetaClassMethod SignalFormedMetaClass;
        #endregion



        public TestSendStruct testSendStruct;
        public Test2SendStruct test2SendStruct;

        public MMS()
        {

        }

        public MMS(TestSendStruct testSendStruct)
        {
            this.testSendStruct = testSendStruct;

        }

        public MMS(Test2SendStruct testSendStruct)
        {
            this.test2SendStruct = testSendStruct;

        }

        public void StartSubscription()
        {
            throw new NotImplementedException();
        }

        //Определение класса
        public void ExecutionProcessingReguest(object struct_which_need_transfer)
        {
            if (struct_which_need_transfer is MMS)
            {
                MMS ms = (MMS)struct_which_need_transfer;

                testSendStruct = ms.testSendStruct;
                test2SendStruct = ms.test2SendStruct;
                SignalFormedMetaClass?.Invoke(ms);
            }
        }

    }

    [Serializable]
    public class VMS : EventSubscriptionInterface
    {
        #region События
        public delegate void SignalFormedMetaClassMethod(VMS vms);
        public event SignalFormedMetaClassMethod SignalFormedMetaClass;
        #endregion


        public Test3SendStruct test3SendStruct;
        public Test4SendStruct test4SendStruct;

        public VMS()
        {
        }

        public VMS(Test4SendStruct test4SendStruct)
        {
            this.test4SendStruct = test4SendStruct;
        }


        public void StartSubscription(object struct_which_need_transfer)
        {
            if (struct_which_need_transfer is VMS)
            {
                VMS ms = (VMS)struct_which_need_transfer;

                test3SendStruct = ms.test3SendStruct;
                test4SendStruct = ms.test4SendStruct;


            }
        }


        public void ExecutionProcessingReguest(object struct_which_need_transfer)
        {
            if (struct_which_need_transfer is VMS)
            {
                VMS vm = (VMS)struct_which_need_transfer;

                this.test3SendStruct = vm.test3SendStruct;
                this.test4SendStruct = vm.test4SendStruct;
                SignalFormedMetaClass?.Invoke(vm);
            }
        }


        public void StartSubscription()
        {
            throw new NotImplementedException();
        }
    }
}
