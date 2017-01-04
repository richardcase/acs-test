FROM microsoft/aspnetcore:1.0.1

WORKDIR /app

COPY . .

EXPOSE 5000

ENTRYPOINT ["dotnet",]
CMD ["run", "-e Production","AcsTest.WebAPI.dll"]

# Build-time metadata as defined at http://label-schema.org
ARG BUILD_DATE
ARG VCS_REF
ARG VERSION
LABEL org.label-schema.build-date=$BUILD_DATE \
    org.label-schema.name="ACS Test API" \
    org.label-schema.description="A simple .NET Core service" \
    org.label-schema.url="https://github.com/richardcase/acs-test" \
    org.label-schema.vcs-ref=$VCS_REF \
    org.label-schema.vcs-url="https://github.com/richardcase/acs-test" \
    org.label-schema.vendor="Richard Case" \
    org.label-schema.version=$VERSION \
org.label-schema.schema-version="1.0"