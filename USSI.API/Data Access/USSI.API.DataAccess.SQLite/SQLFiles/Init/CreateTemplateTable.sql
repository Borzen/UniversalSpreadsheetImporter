CREATE TABLE Template (
    TemplateId       INTEGER  PRIMARY KEY AUTOINCREMENT
                              NOT NULL,
    TemplateName     TEXT     NOT NULL,
    FileExtension    TEXT     NOT NULL,
    ColumnDelimiter  TEXT (1),
    QuoteDelimiter   TEXT (1),
    CreatedDateTime  TEXT     DEFAULT (DATETIME('now') ) 
                              NOT NULL,
    ModifiedDateTime TEXT     DEFAULT (DATETIME('now') ) 
                              NOT NULL
);
