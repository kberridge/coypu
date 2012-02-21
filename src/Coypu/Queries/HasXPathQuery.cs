namespace Coypu.Queries
{
    internal class HasXPathQuery : XPathQuery
    {
        public HasXPathQuery(Driver driver, DriverScope scope, string xpath)
            : base(driver, scope, xpath)
        {
        }

        public override bool ExpectedResult
        {
            get { return true; }
        }
    }
}