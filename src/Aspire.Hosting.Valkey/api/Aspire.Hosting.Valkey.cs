//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Aspire.Hosting
{
    public static partial class ValkeyBuilderExtensions
    {
        public static ApplicationModel.IResourceBuilder<ApplicationModel.ValkeyResource> AddValkey(this IDistributedApplicationBuilder builder, string name, int? port = null, ApplicationModel.IResourceBuilder<ApplicationModel.ParameterResource>? password = null) { throw null; }

        public static ApplicationModel.IResourceBuilder<ApplicationModel.ValkeyResource> AddValkey(this IDistributedApplicationBuilder builder, string name, int? port) { throw null; }

        public static ApplicationModel.IResourceBuilder<ApplicationModel.ValkeyResource> WithDataBindMount(this ApplicationModel.IResourceBuilder<ApplicationModel.ValkeyResource> builder, string source, bool isReadOnly = false) { throw null; }

        public static ApplicationModel.IResourceBuilder<ApplicationModel.ValkeyResource> WithDataVolume(this ApplicationModel.IResourceBuilder<ApplicationModel.ValkeyResource> builder, string? name = null, bool isReadOnly = false) { throw null; }

        public static ApplicationModel.IResourceBuilder<ApplicationModel.ValkeyResource> WithPersistence(this ApplicationModel.IResourceBuilder<ApplicationModel.ValkeyResource> builder, System.TimeSpan? interval = null, long keysChangedThreshold = 1) { throw null; }
    }
}

namespace Aspire.Hosting.ApplicationModel
{
    public partial class ValkeyResource : ContainerResource, IResourceWithConnectionString, IResource, IManifestExpressionProvider, IValueProvider, IValueWithReferences
    {
        public ValkeyResource(string name, ParameterResource password) : base(default!, default) { }

        public ValkeyResource(string name) : base(default!, default) { }

        public ReferenceExpression ConnectionStringExpression { get { throw null; } }

        public ParameterResource? PasswordParameter { get { throw null; } }

        public EndpointReference PrimaryEndpoint { get { throw null; } }
    }
}