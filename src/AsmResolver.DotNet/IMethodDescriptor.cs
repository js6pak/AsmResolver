using AsmResolver.DotNet.Signatures;

namespace AsmResolver.DotNet
{
    /// <summary>
    /// Provides members for describing a method in a managed assembly.
    /// </summary>
    public interface IMethodDescriptor : IMemberDescriptor, IMetadataMember
    {
        /// <summary>
        /// Gets the name of the method.
        /// </summary>
        new Utf8String? Name
        {
            get;
        }

        /// <summary>
        /// Gets the signature of the method.
        /// </summary>
        MethodSignature? Signature
        {
            get;
        }

        /// <summary>
        /// Imports the method using the provided reference importer object.
        /// </summary>
        /// <param name="importer">The reference importer to use.</param>
        /// <returns>The imported method.</returns>
        new IMethodDescriptor ImportWith(ReferenceImporter importer);

        /// <summary>
        /// Resolves the reference to a method definition.
        /// </summary>
        /// <returns>The resolved method definition, or <c>null</c> if the method could not be resolved.</returns>
        /// <remarks>
        /// This method assumes the context module as the resolution context.
        /// </remarks>
        new MethodDefinition? Resolve();

        /// <summary>
        /// Resolves the reference to a method definition, assuming the provided module as resolution context.
        /// </summary>
        /// <param name="context">The module to assume as resolution context.</param>
        /// <returns>The resolved method definition, or <c>null</c> if the method could not be resolved.</returns>
        new MethodDefinition? Resolve(ModuleDefinition context);
    }
}
