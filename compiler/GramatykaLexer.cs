//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\annar\Desktop\Kompilator\Kom\Gramatyka.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class GramatykaLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, TYPE=9, 
		LP=10, RP=11, ADD=12, SUB=13, MUL=14, DIV=15, WHILE=16, IF=17, FUNCTION=18, 
		READREAL=19, READINT=20, PRINT=21, STRING=22, ID=23, INT=24, REAL=25, 
		NEWLINE=26, WHITESPACE=27, COMMENT=28;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "TYPE", 
		"LP", "RP", "ADD", "SUB", "MUL", "DIV", "WHILE", "IF", "FUNCTION", "READREAL", 
		"READINT", "PRINT", "STRING", "ID", "INT", "REAL", "NEWLINE", "WHITESPACE", 
		"COMMENT"
	};


	public GramatykaLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public GramatykaLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'='", "'['", "']'", "'()'", "'{'", "'}'", "','", "'=='", null, 
		"'('", "')'", "'+'", "'-'", "'*'", "'/'", "'while'", "'if'", "'func'", 
		"'ReadReal'", "'ReadInt'", "'Print'", null, null, null, null, null, "' '"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, "TYPE", "LP", "RP", 
		"ADD", "SUB", "MUL", "DIV", "WHILE", "IF", "FUNCTION", "READREAL", "READINT", 
		"PRINT", "STRING", "ID", "INT", "REAL", "NEWLINE", "WHITESPACE", "COMMENT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Gramatyka.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static GramatykaLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x1E', '\xBF', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x5', '\n', 
		'U', '\n', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', 
		'\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', 
		'\x3', '\x17', '\a', '\x17', '\x8A', '\n', '\x17', '\f', '\x17', '\xE', 
		'\x17', '\x8D', '\v', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', 
		'\x6', '\x18', '\x92', '\n', '\x18', '\r', '\x18', '\xE', '\x18', '\x93', 
		'\x3', '\x19', '\x5', '\x19', '\x97', '\n', '\x19', '\x3', '\x19', '\x6', 
		'\x19', '\x9A', '\n', '\x19', '\r', '\x19', '\xE', '\x19', '\x9B', '\x3', 
		'\x1A', '\x5', '\x1A', '\x9F', '\n', '\x1A', '\x3', '\x1A', '\x6', '\x1A', 
		'\xA2', '\n', '\x1A', '\r', '\x1A', '\xE', '\x1A', '\xA3', '\x3', '\x1A', 
		'\x3', '\x1A', '\x6', '\x1A', '\xA8', '\n', '\x1A', '\r', '\x1A', '\xE', 
		'\x1A', '\xA9', '\x3', '\x1B', '\x5', '\x1B', '\xAD', '\n', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', 
		'\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\a', 
		'\x1D', '\xB9', '\n', '\x1D', '\f', '\x1D', '\xE', '\x1D', '\xBC', '\v', 
		'\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x2', '\x2', '\x1E', '\x3', '\x3', 
		'\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', 
		'\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', 
		'\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', 
		'\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', 
		'/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', '\x3', '\x2', '\x5', '\x4', '\x2', '$', '$', '^', '^', 
		'\x4', '\x2', '\x43', '\\', '\x63', '|', '\x4', '\x2', '\f', '\f', '\xF', 
		'\xF', '\x2', '\xC8', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', 
		'\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\x3', ';', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'=', '\x3', '\x2', '\x2', '\x2', '\a', '?', '\x3', '\x2', '\x2', '\x2', 
		'\t', '\x41', '\x3', '\x2', '\x2', '\x2', '\v', '\x44', '\x3', '\x2', 
		'\x2', '\x2', '\r', '\x46', '\x3', '\x2', '\x2', '\x2', '\xF', 'H', '\x3', 
		'\x2', '\x2', '\x2', '\x11', 'J', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'T', '\x3', '\x2', '\x2', '\x2', '\x15', 'V', '\x3', '\x2', '\x2', '\x2', 
		'\x17', 'X', '\x3', '\x2', '\x2', '\x2', '\x19', 'Z', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', '\\', '\x3', '\x2', '\x2', '\x2', '\x1D', '^', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', '`', '\x3', '\x2', '\x2', '\x2', '!', '\x62', '\x3', 
		'\x2', '\x2', '\x2', '#', 'h', '\x3', '\x2', '\x2', '\x2', '%', 'k', '\x3', 
		'\x2', '\x2', '\x2', '\'', 'p', '\x3', '\x2', '\x2', '\x2', ')', 'y', 
		'\x3', '\x2', '\x2', '\x2', '+', '\x81', '\x3', '\x2', '\x2', '\x2', '-', 
		'\x87', '\x3', '\x2', '\x2', '\x2', '/', '\x91', '\x3', '\x2', '\x2', 
		'\x2', '\x31', '\x96', '\x3', '\x2', '\x2', '\x2', '\x33', '\x9E', '\x3', 
		'\x2', '\x2', '\x2', '\x35', '\xAC', '\x3', '\x2', '\x2', '\x2', '\x37', 
		'\xB0', '\x3', '\x2', '\x2', '\x2', '\x39', '\xB4', '\x3', '\x2', '\x2', 
		'\x2', ';', '<', '\a', '?', '\x2', '\x2', '<', '\x4', '\x3', '\x2', '\x2', 
		'\x2', '=', '>', '\a', ']', '\x2', '\x2', '>', '\x6', '\x3', '\x2', '\x2', 
		'\x2', '?', '@', '\a', '_', '\x2', '\x2', '@', '\b', '\x3', '\x2', '\x2', 
		'\x2', '\x41', '\x42', '\a', '*', '\x2', '\x2', '\x42', '\x43', '\a', 
		'+', '\x2', '\x2', '\x43', '\n', '\x3', '\x2', '\x2', '\x2', '\x44', '\x45', 
		'\a', '}', '\x2', '\x2', '\x45', '\f', '\x3', '\x2', '\x2', '\x2', '\x46', 
		'G', '\a', '\x7F', '\x2', '\x2', 'G', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'H', 'I', '\a', '.', '\x2', '\x2', 'I', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'J', 'K', '\a', '?', '\x2', '\x2', 'K', 'L', '\a', '?', '\x2', '\x2', 
		'L', '\x12', '\x3', '\x2', '\x2', '\x2', 'M', 'N', '\a', 'K', '\x2', '\x2', 
		'N', 'O', '\a', 'P', '\x2', '\x2', 'O', 'U', '\a', 'V', '\x2', '\x2', 
		'P', 'Q', '\a', 'T', '\x2', '\x2', 'Q', 'R', '\a', 'G', '\x2', '\x2', 
		'R', 'S', '\a', '\x43', '\x2', '\x2', 'S', 'U', '\a', 'N', '\x2', '\x2', 
		'T', 'M', '\x3', '\x2', '\x2', '\x2', 'T', 'P', '\x3', '\x2', '\x2', '\x2', 
		'U', '\x14', '\x3', '\x2', '\x2', '\x2', 'V', 'W', '\a', '*', '\x2', '\x2', 
		'W', '\x16', '\x3', '\x2', '\x2', '\x2', 'X', 'Y', '\a', '+', '\x2', '\x2', 
		'Y', '\x18', '\x3', '\x2', '\x2', '\x2', 'Z', '[', '\a', '-', '\x2', '\x2', 
		'[', '\x1A', '\x3', '\x2', '\x2', '\x2', '\\', ']', '\a', '/', '\x2', 
		'\x2', ']', '\x1C', '\x3', '\x2', '\x2', '\x2', '^', '_', '\a', ',', '\x2', 
		'\x2', '_', '\x1E', '\x3', '\x2', '\x2', '\x2', '`', '\x61', '\a', '\x31', 
		'\x2', '\x2', '\x61', ' ', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', 
		'\a', 'y', '\x2', '\x2', '\x63', '\x64', '\a', 'j', '\x2', '\x2', '\x64', 
		'\x65', '\a', 'k', '\x2', '\x2', '\x65', '\x66', '\a', 'n', '\x2', '\x2', 
		'\x66', 'g', '\a', 'g', '\x2', '\x2', 'g', '\"', '\x3', '\x2', '\x2', 
		'\x2', 'h', 'i', '\a', 'k', '\x2', '\x2', 'i', 'j', '\a', 'h', '\x2', 
		'\x2', 'j', '$', '\x3', '\x2', '\x2', '\x2', 'k', 'l', '\a', 'h', '\x2', 
		'\x2', 'l', 'm', '\a', 'w', '\x2', '\x2', 'm', 'n', '\a', 'p', '\x2', 
		'\x2', 'n', 'o', '\a', '\x65', '\x2', '\x2', 'o', '&', '\x3', '\x2', '\x2', 
		'\x2', 'p', 'q', '\a', 'T', '\x2', '\x2', 'q', 'r', '\a', 'g', '\x2', 
		'\x2', 'r', 's', '\a', '\x63', '\x2', '\x2', 's', 't', '\a', '\x66', '\x2', 
		'\x2', 't', 'u', '\a', 'T', '\x2', '\x2', 'u', 'v', '\a', 'g', '\x2', 
		'\x2', 'v', 'w', '\a', '\x63', '\x2', '\x2', 'w', 'x', '\a', 'n', '\x2', 
		'\x2', 'x', '(', '\x3', '\x2', '\x2', '\x2', 'y', 'z', '\a', 'T', '\x2', 
		'\x2', 'z', '{', '\a', 'g', '\x2', '\x2', '{', '|', '\a', '\x63', '\x2', 
		'\x2', '|', '}', '\a', '\x66', '\x2', '\x2', '}', '~', '\a', 'K', '\x2', 
		'\x2', '~', '\x7F', '\a', 'p', '\x2', '\x2', '\x7F', '\x80', '\a', 'v', 
		'\x2', '\x2', '\x80', '*', '\x3', '\x2', '\x2', '\x2', '\x81', '\x82', 
		'\a', 'R', '\x2', '\x2', '\x82', '\x83', '\a', 't', '\x2', '\x2', '\x83', 
		'\x84', '\a', 'k', '\x2', '\x2', '\x84', '\x85', '\a', 'p', '\x2', '\x2', 
		'\x85', '\x86', '\a', 'v', '\x2', '\x2', '\x86', ',', '\x3', '\x2', '\x2', 
		'\x2', '\x87', '\x8B', '\a', '$', '\x2', '\x2', '\x88', '\x8A', '\n', 
		'\x2', '\x2', '\x2', '\x89', '\x88', '\x3', '\x2', '\x2', '\x2', '\x8A', 
		'\x8D', '\x3', '\x2', '\x2', '\x2', '\x8B', '\x89', '\x3', '\x2', '\x2', 
		'\x2', '\x8B', '\x8C', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x8E', '\x3', 
		'\x2', '\x2', '\x2', '\x8D', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x8E', 
		'\x8F', '\a', '$', '\x2', '\x2', '\x8F', '.', '\x3', '\x2', '\x2', '\x2', 
		'\x90', '\x92', '\t', '\x3', '\x2', '\x2', '\x91', '\x90', '\x3', '\x2', 
		'\x2', '\x2', '\x92', '\x93', '\x3', '\x2', '\x2', '\x2', '\x93', '\x91', 
		'\x3', '\x2', '\x2', '\x2', '\x93', '\x94', '\x3', '\x2', '\x2', '\x2', 
		'\x94', '\x30', '\x3', '\x2', '\x2', '\x2', '\x95', '\x97', '\x5', '\x1B', 
		'\xE', '\x2', '\x96', '\x95', '\x3', '\x2', '\x2', '\x2', '\x96', '\x97', 
		'\x3', '\x2', '\x2', '\x2', '\x97', '\x99', '\x3', '\x2', '\x2', '\x2', 
		'\x98', '\x9A', '\x4', '\x32', ';', '\x2', '\x99', '\x98', '\x3', '\x2', 
		'\x2', '\x2', '\x9A', '\x9B', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x99', 
		'\x3', '\x2', '\x2', '\x2', '\x9B', '\x9C', '\x3', '\x2', '\x2', '\x2', 
		'\x9C', '\x32', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x9F', '\x5', '\x1B', 
		'\xE', '\x2', '\x9E', '\x9D', '\x3', '\x2', '\x2', '\x2', '\x9E', '\x9F', 
		'\x3', '\x2', '\x2', '\x2', '\x9F', '\xA1', '\x3', '\x2', '\x2', '\x2', 
		'\xA0', '\xA2', '\x4', '\x32', ';', '\x2', '\xA1', '\xA0', '\x3', '\x2', 
		'\x2', '\x2', '\xA2', '\xA3', '\x3', '\x2', '\x2', '\x2', '\xA3', '\xA1', 
		'\x3', '\x2', '\x2', '\x2', '\xA3', '\xA4', '\x3', '\x2', '\x2', '\x2', 
		'\xA4', '\xA5', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA7', '\a', '\x30', 
		'\x2', '\x2', '\xA6', '\xA8', '\x4', '\x32', ';', '\x2', '\xA7', '\xA6', 
		'\x3', '\x2', '\x2', '\x2', '\xA8', '\xA9', '\x3', '\x2', '\x2', '\x2', 
		'\xA9', '\xA7', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAA', '\x3', '\x2', 
		'\x2', '\x2', '\xAA', '\x34', '\x3', '\x2', '\x2', '\x2', '\xAB', '\xAD', 
		'\a', '\xF', '\x2', '\x2', '\xAC', '\xAB', '\x3', '\x2', '\x2', '\x2', 
		'\xAC', '\xAD', '\x3', '\x2', '\x2', '\x2', '\xAD', '\xAE', '\x3', '\x2', 
		'\x2', '\x2', '\xAE', '\xAF', '\a', '\f', '\x2', '\x2', '\xAF', '\x36', 
		'\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', '\a', '\"', '\x2', '\x2', 
		'\xB1', '\xB2', '\x3', '\x2', '\x2', '\x2', '\xB2', '\xB3', '\b', '\x1C', 
		'\x2', '\x2', '\xB3', '\x38', '\x3', '\x2', '\x2', '\x2', '\xB4', '\xB5', 
		'\a', '\x31', '\x2', '\x2', '\xB5', '\xB6', '\a', '\x31', '\x2', '\x2', 
		'\xB6', '\xBA', '\x3', '\x2', '\x2', '\x2', '\xB7', '\xB9', '\n', '\x4', 
		'\x2', '\x2', '\xB8', '\xB7', '\x3', '\x2', '\x2', '\x2', '\xB9', '\xBC', 
		'\x3', '\x2', '\x2', '\x2', '\xBA', '\xB8', '\x3', '\x2', '\x2', '\x2', 
		'\xBA', '\xBB', '\x3', '\x2', '\x2', '\x2', '\xBB', '\xBD', '\x3', '\x2', 
		'\x2', '\x2', '\xBC', '\xBA', '\x3', '\x2', '\x2', '\x2', '\xBD', '\xBE', 
		'\b', '\x1D', '\x2', '\x2', '\xBE', ':', '\x3', '\x2', '\x2', '\x2', '\r', 
		'\x2', 'T', '\x8B', '\x93', '\x96', '\x9B', '\x9E', '\xA3', '\xA9', '\xAC', 
		'\xBA', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}