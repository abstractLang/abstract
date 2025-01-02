Prism.languages.abs = {
	'comment': {
		pattern: /#(?!##).*|###[\s\S]*?###/,
		greedy: true
	},
    'char': {
		pattern: /'(?:\\(?:\r\n|[\s\S])|[^'\\\r\n]){0,32}'/,
		greedy: true
	},
	'string': {
		pattern: /"(?:\\(?:\r\n|[\s\S])|[^"\\\r\n])*"/,
		greedy: true,

		inside: {
			'interpolation': {
				pattern: /\\{[^}]*}/,
				
				inside: {
					'tag': /(\\{|})/,
					'plain': {
						pattern: /.+/,
						inside: Prism.languages.abs
					}
				}
			}
		}
	},
	'number': /\b(\d+.\d+|\d+|0x[0-9a-fA-F_]+|0b[01_]+)\b/,

	'keyword': /\b(import|from|namespace|func|struct|packet|match|switch|case|enum|default|let|const|new|Flag|as|in|by|for|while|break|if|elif|else|and|or)\b/,
	'type': /(\[\]|\*)*([iu](8|16|32|64|128|ptr)|byte|f32|f64|float|double|string|char|bool|type|anytype|void|noreturn)\b/,

	'boolean': /\b(true|false)\b/,

    'property': /@([a-zA-Z_][a-zA-Z0-9_]*)/,
	'function': /\b[a-zA-Z_][a-zA-Z0-9_]*(?=\()\b/,

	'operator': /(\+\+|\*\*|==|>=|<=|\!=|\+=|-=|\*=|\/=|%=|=>|\+|-|\*|\/|%|=|>|<)/,
    'punctuation': /(\[|\]|{|}|\(|\))/
};
