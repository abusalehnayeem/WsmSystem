namespace WsmSystem.Erp.BusinessLaw
{
    public class BusinessLaw : IBusinessLaw
    {
        private BusinessLaw()
        {

        }

        public static IBusinessLaw Instance { get; } = new BusinessLaw();
    }
}
