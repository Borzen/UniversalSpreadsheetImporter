CREATE TABLE IF NOT EXISTS "Template" (
	"TemplateId" INTEGER NOT NULL,
	"TemplateName" VARCHAR(100) NOT NULL,
	"FileExtesnion" VARCHAR(15) NOT NULL,
	"ColumnDelimiter" CHAR(1) NULL,
	"QuoteDelimiter" CHAR(1) NULL,
	"CreatedDateTime" DATETIME NOT NULL,
	"ModifiedDateTime" DATETIME NOT NULL,
	PRIMARY KEY ("TemplateId")
);