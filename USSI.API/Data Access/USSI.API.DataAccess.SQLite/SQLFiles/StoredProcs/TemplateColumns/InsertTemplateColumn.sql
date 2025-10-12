Insert into TemplateColumn
(
	TemplateId,
	Name,
	DataType,
	Required
)
values
(
	@templateId,
	@name,
	@dataType,
	@required
);
Select last_insert_rowid();