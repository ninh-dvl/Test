using System;
using System.Reflection;

namespace EAP_Product_NGUYEN_KHANH_NINH.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}