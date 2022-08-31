using Atrributes.Attributes;
using Atrributes.Model;
using System.Reflection;

IEnumerable<string> GetcolumnNames<T>(T entity)
{
    List<string> columnNames = new List<string>();
	foreach (PropertyInfo info in entity.GetType().GetProperties())
	{
		bool result = Attribute.IsDefined(info, typeof(ColumnName));
		if (result)
		{
			ColumnName attr = (ColumnName)info.GetCustomAttribute(typeof(ColumnName), true);
			columnNames.Add(attr.DisplayName ?? info.Name);
            //columnNames.Add(info.Name);

        }
		//Console.WriteLine($"{info.Name} -> {result}");
	}

	return columnNames;
}


var names= GetcolumnNames(new Employee());
foreach (var name in names)
{
	Console.WriteLine(name);
}