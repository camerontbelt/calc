// Generated from c:\Users\cbelt\Source\repos\calc\calc\calc.g4 by ANTLR 4.8
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class calcParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, INT=17, 
		WS=18;
	public static final int
		RULE_logical_operations = 0, RULE_bool = 1, RULE_addition_subtraction = 2, 
		RULE_mult_div = 3, RULE_exponent = 4, RULE_expr = 5, RULE_float_num = 6, 
		RULE_num = 7;
	private static String[] makeRuleNames() {
		return new String[] {
			"logical_operations", "bool", "addition_subtraction", "mult_div", "exponent", 
			"expr", "float_num", "num"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'&'", "'|'", "'>'", "'<'", "'>='", "'<='", "'=='", "'+'", "'-'", 
			"'*'", "'/'", "'^'", "'('", "')'", "'!'", "'.'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, "INT", "WS"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "calc.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public calcParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class Logical_operationsContext extends ParserRuleContext {
		public List<BoolContext> bool() {
			return getRuleContexts(BoolContext.class);
		}
		public BoolContext bool(int i) {
			return getRuleContext(BoolContext.class,i);
		}
		public Logical_operationsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_logical_operations; }
	}

	public final Logical_operationsContext logical_operations() throws RecognitionException {
		Logical_operationsContext _localctx = new Logical_operationsContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_logical_operations);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(16);
			bool();
			setState(23);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__0 || _la==T__1) {
				{
				setState(19); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(17);
					_la = _input.LA(1);
					if ( !(_la==T__0 || _la==T__1) ) {
					_errHandler.recoverInline(this);
					}
					else {
						if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
						_errHandler.reportMatch(this);
						consume();
					}
					setState(18);
					bool();
					}
					}
					setState(21); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==T__0 || _la==T__1 );
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class BoolContext extends ParserRuleContext {
		public List<Addition_subtractionContext> addition_subtraction() {
			return getRuleContexts(Addition_subtractionContext.class);
		}
		public Addition_subtractionContext addition_subtraction(int i) {
			return getRuleContext(Addition_subtractionContext.class,i);
		}
		public BoolContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_bool; }
	}

	public final BoolContext bool() throws RecognitionException {
		BoolContext _localctx = new BoolContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_bool);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(25);
			addition_subtraction();
			setState(32);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6))) != 0)) {
				{
				setState(28); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(26);
					_la = _input.LA(1);
					if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6))) != 0)) ) {
					_errHandler.recoverInline(this);
					}
					else {
						if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
						_errHandler.reportMatch(this);
						consume();
					}
					setState(27);
					addition_subtraction();
					}
					}
					setState(30); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6))) != 0) );
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Addition_subtractionContext extends ParserRuleContext {
		public List<Mult_divContext> mult_div() {
			return getRuleContexts(Mult_divContext.class);
		}
		public Mult_divContext mult_div(int i) {
			return getRuleContext(Mult_divContext.class,i);
		}
		public Addition_subtractionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_addition_subtraction; }
	}

	public final Addition_subtractionContext addition_subtraction() throws RecognitionException {
		Addition_subtractionContext _localctx = new Addition_subtractionContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_addition_subtraction);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(34);
			mult_div();
			setState(41);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__7 || _la==T__8) {
				{
				setState(37); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(35);
					_la = _input.LA(1);
					if ( !(_la==T__7 || _la==T__8) ) {
					_errHandler.recoverInline(this);
					}
					else {
						if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
						_errHandler.reportMatch(this);
						consume();
					}
					setState(36);
					mult_div();
					}
					}
					setState(39); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==T__7 || _la==T__8 );
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Mult_divContext extends ParserRuleContext {
		public List<ExponentContext> exponent() {
			return getRuleContexts(ExponentContext.class);
		}
		public ExponentContext exponent(int i) {
			return getRuleContext(ExponentContext.class,i);
		}
		public Mult_divContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_mult_div; }
	}

	public final Mult_divContext mult_div() throws RecognitionException {
		Mult_divContext _localctx = new Mult_divContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_mult_div);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(43);
			exponent();
			setState(50);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,7,_ctx) ) {
			case 1:
				{
				setState(46); 
				_errHandler.sync(this);
				_alt = 1;
				do {
					switch (_alt) {
					case 1:
						{
						{
						setState(44);
						_la = _input.LA(1);
						if ( !(_la==T__9 || _la==T__10) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(45);
						exponent();
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					setState(48); 
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,6,_ctx);
				} while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ExponentContext extends ParserRuleContext {
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public ExponentContext exponent() {
			return getRuleContext(ExponentContext.class,0);
		}
		public ExponentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_exponent; }
	}

	public final ExponentContext exponent() throws RecognitionException {
		ExponentContext _localctx = new ExponentContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_exponent);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(52);
			expr();
			setState(55);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,8,_ctx) ) {
			case 1:
				{
				setState(53);
				match(T__11);
				setState(54);
				exponent();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ExprContext extends ParserRuleContext {
		public Float_numContext float_num() {
			return getRuleContext(Float_numContext.class,0);
		}
		public Logical_operationsContext logical_operations() {
			return getRuleContext(Logical_operationsContext.class,0);
		}
		public Mult_divContext mult_div() {
			return getRuleContext(Mult_divContext.class,0);
		}
		public TerminalNode EOF() { return getToken(calcParser.EOF, 0); }
		public ExprContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expr; }
	}

	public final ExprContext expr() throws RecognitionException {
		ExprContext _localctx = new ExprContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_expr);
		try {
			setState(70);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case INT:
				enterOuterAlt(_localctx, 1);
				{
				setState(57);
				float_num();
				}
				break;
			case T__12:
				enterOuterAlt(_localctx, 2);
				{
				setState(58);
				match(T__12);
				setState(59);
				logical_operations();
				setState(60);
				match(T__13);
				}
				break;
			case T__8:
				enterOuterAlt(_localctx, 3);
				{
				setState(62);
				match(T__8);
				setState(63);
				mult_div();
				}
				break;
			case T__14:
				enterOuterAlt(_localctx, 4);
				{
				setState(64);
				match(T__14);
				setState(65);
				match(T__12);
				setState(66);
				logical_operations();
				setState(67);
				match(T__13);
				}
				break;
			case EOF:
				enterOuterAlt(_localctx, 5);
				{
				setState(69);
				match(EOF);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Float_numContext extends ParserRuleContext {
		public List<NumContext> num() {
			return getRuleContexts(NumContext.class);
		}
		public NumContext num(int i) {
			return getRuleContext(NumContext.class,i);
		}
		public Float_numContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_float_num; }
	}

	public final Float_numContext float_num() throws RecognitionException {
		Float_numContext _localctx = new Float_numContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_float_num);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(72);
			num();
			setState(75);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__15) {
				{
				setState(73);
				match(T__15);
				setState(74);
				num();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class NumContext extends ParserRuleContext {
		public List<TerminalNode> INT() { return getTokens(calcParser.INT); }
		public TerminalNode INT(int i) {
			return getToken(calcParser.INT, i);
		}
		public NumContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_num; }
	}

	public final NumContext num() throws RecognitionException {
		NumContext _localctx = new NumContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_num);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(77);
			match(INT);
			setState(83);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==INT) {
				{
				setState(79); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(78);
					match(INT);
					}
					}
					setState(81); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==INT );
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\24X\4\2\t\2\4\3\t"+
		"\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\3\2\3\2\3\2\6\2\26"+
		"\n\2\r\2\16\2\27\5\2\32\n\2\3\3\3\3\3\3\6\3\37\n\3\r\3\16\3 \5\3#\n\3"+
		"\3\4\3\4\3\4\6\4(\n\4\r\4\16\4)\5\4,\n\4\3\5\3\5\3\5\6\5\61\n\5\r\5\16"+
		"\5\62\5\5\65\n\5\3\6\3\6\3\6\5\6:\n\6\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7"+
		"\3\7\3\7\3\7\3\7\3\7\5\7I\n\7\3\b\3\b\3\b\5\bN\n\b\3\t\3\t\6\tR\n\t\r"+
		"\t\16\tS\5\tV\n\t\3\t\2\2\n\2\4\6\b\n\f\16\20\2\6\3\2\3\4\3\2\5\t\3\2"+
		"\n\13\3\2\f\r\2_\2\22\3\2\2\2\4\33\3\2\2\2\6$\3\2\2\2\b-\3\2\2\2\n\66"+
		"\3\2\2\2\fH\3\2\2\2\16J\3\2\2\2\20O\3\2\2\2\22\31\5\4\3\2\23\24\t\2\2"+
		"\2\24\26\5\4\3\2\25\23\3\2\2\2\26\27\3\2\2\2\27\25\3\2\2\2\27\30\3\2\2"+
		"\2\30\32\3\2\2\2\31\25\3\2\2\2\31\32\3\2\2\2\32\3\3\2\2\2\33\"\5\6\4\2"+
		"\34\35\t\3\2\2\35\37\5\6\4\2\36\34\3\2\2\2\37 \3\2\2\2 \36\3\2\2\2 !\3"+
		"\2\2\2!#\3\2\2\2\"\36\3\2\2\2\"#\3\2\2\2#\5\3\2\2\2$+\5\b\5\2%&\t\4\2"+
		"\2&(\5\b\5\2\'%\3\2\2\2()\3\2\2\2)\'\3\2\2\2)*\3\2\2\2*,\3\2\2\2+\'\3"+
		"\2\2\2+,\3\2\2\2,\7\3\2\2\2-\64\5\n\6\2./\t\5\2\2/\61\5\n\6\2\60.\3\2"+
		"\2\2\61\62\3\2\2\2\62\60\3\2\2\2\62\63\3\2\2\2\63\65\3\2\2\2\64\60\3\2"+
		"\2\2\64\65\3\2\2\2\65\t\3\2\2\2\669\5\f\7\2\678\7\16\2\28:\5\n\6\29\67"+
		"\3\2\2\29:\3\2\2\2:\13\3\2\2\2;I\5\16\b\2<=\7\17\2\2=>\5\2\2\2>?\7\20"+
		"\2\2?I\3\2\2\2@A\7\13\2\2AI\5\b\5\2BC\7\21\2\2CD\7\17\2\2DE\5\2\2\2EF"+
		"\7\20\2\2FI\3\2\2\2GI\7\2\2\3H;\3\2\2\2H<\3\2\2\2H@\3\2\2\2HB\3\2\2\2"+
		"HG\3\2\2\2I\r\3\2\2\2JM\5\20\t\2KL\7\22\2\2LN\5\20\t\2MK\3\2\2\2MN\3\2"+
		"\2\2N\17\3\2\2\2OU\7\23\2\2PR\7\23\2\2QP\3\2\2\2RS\3\2\2\2SQ\3\2\2\2S"+
		"T\3\2\2\2TV\3\2\2\2UQ\3\2\2\2UV\3\2\2\2V\21\3\2\2\2\17\27\31 \")+\62\64"+
		"9HMSU";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}