CREATE TABLE TemplateColumn (
    TemplateColumnId INTEGER PRIMARY KEY AUTOINCREMENT
                             NOT NULL,
    TemplateId       INTEGER REFERENCES Template (TemplateId) 
                             NOT NULL,
    Name             TEXT    NOT NULL,
    DataType         TEXT    NOT NULL,
    Required         INTEGER NOT NULL
                             DEFAULT (0) 
);
