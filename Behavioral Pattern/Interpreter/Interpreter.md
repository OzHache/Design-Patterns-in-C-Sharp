# The Interpreter
The Interpreter Pattern is a behavioral design pattern that lets you define a grammar for a language and then define a corresponding interpreter that uses the grammar to interpret sentences in the language.

An Example for this might be a calculator that can interpret a string like "1 + 2" and return the result 3.

The members of the Interpreter Pattern are:
- AbstractExpression: declares an interface for executing an operation.
- TerminalExpression: implements an Interpret operation associated with terminal symbols in the grammar. An instance is required for every terminal symbol in a sentence.
- NonterminalExpression: implements an Interpret operation for nonterminal symbols in the grammar. One such class is required
    - for every rule R ::= R1 R2 ... Rn in the grammar. Interpret typically calls itself recursively on the variables representing R1 through Rn.
- Context: contains information that is global to the interpreter.
- Client: builds (or is given) an abstract syntax tree representing a particular sentence in the language that the grammar defines. The abstract syntax tree is assembled from instances of the NonterminalExpression and TerminalExpression classes. The client invokes the Interpret operation.
