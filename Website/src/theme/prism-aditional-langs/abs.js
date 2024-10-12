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
		greedy: true
	},

	'keyword': /\b(using|namespace|func|struct|let|const|new|true|false|[iu]\d+|byte|f32|f64|float|double|string|char|Flag)\b/,

    'symbol': /\b@[a-z_]\w*/i,
	'function': /(?<!@)\b[a-z_]\w*(?=\s*\()/i,

    'punctuation': /[\[\]{}\(\)]/
};
