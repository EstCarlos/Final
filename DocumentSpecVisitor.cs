//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from e:\Construccion\Final\DocumentSpec.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="DocumentSpecParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IDocumentSpecVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="DocumentSpecParser.document"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDocument([NotNull] DocumentSpecParser.DocumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DocumentSpecParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitText([NotNull] DocumentSpecParser.TextContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DocumentSpecParser.bold"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBold([NotNull] DocumentSpecParser.BoldContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DocumentSpecParser.italic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitItalic([NotNull] DocumentSpecParser.ItalicContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DocumentSpecParser.underline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnderline([NotNull] DocumentSpecParser.UnderlineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DocumentSpecParser.title"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTitle([NotNull] DocumentSpecParser.TitleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DocumentSpecParser.heading1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeading1([NotNull] DocumentSpecParser.Heading1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DocumentSpecParser.heading2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeading2([NotNull] DocumentSpecParser.Heading2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DocumentSpecParser.heading3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeading3([NotNull] DocumentSpecParser.Heading3Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DocumentSpecParser.nested"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNested([NotNull] DocumentSpecParser.NestedContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DocumentSpecParser.list_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitList_item([NotNull] DocumentSpecParser.List_itemContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DocumentSpecParser.list_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitList_number([NotNull] DocumentSpecParser.List_numberContext context);
}
