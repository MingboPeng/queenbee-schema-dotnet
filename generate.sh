python3 .openapi-generator/pre_gen_script.py ".openapi-docs/queenbee_inheritance.json"

npx @openapitools/openapi-generator-cli generate -i ".openapi-docs/queenbee_inheritance.json"  -t ".openapi-generator/templates/csharp" -g csharp -o . --skip-validate-spec -c .openapi-config.json 

python3 .openapi-generator/post_gen_script.py ".openapi-docs/queenbee_inheritance.json"

python3 .openapi-generator/update_assembly_version.py

python3 .openapi-generator/create_interface.py ".openapi-docs/queenbee_mapper.json"

# dotnet build -c Release -f netstandard2.0 src/HoneybeeSchema