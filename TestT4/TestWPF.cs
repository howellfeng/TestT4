
<misControl:LabelItem Label="主键：" Content="{Binding Data.Certificate.id,Mode=OneWay}"/>
<misControl:LabelItem Label="创建人名称：" Content="{Binding Data.Certificate.create_name,Mode=OneWay}"/>
<misControl:LabelItem Label="创建人登录名称：" Content="{Binding Data.Certificate.create_by,Mode=OneWay}"/>
<misControl:LabelItem Label="创建日期：">
    <TextBlock Text="{Binding Data.Certificate.create_date,Mode=OneWay,StringFormat='{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
</misControl:LabelItem>
<misControl:LabelItem Label="更新人名称：" Content="{Binding Data.Certificate.update_name,Mode=OneWay}"/>
<misControl:LabelItem Label="更新人登录名称：" Content="{Binding Data.Certificate.update_by,Mode=OneWay}"/>
<misControl:LabelItem Label="更新日期：">
    <TextBlock Text="{Binding Data.Certificate.update_date,Mode=OneWay,StringFormat='{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
</misControl:LabelItem>
<misControl:LabelItem Label="所属部门：" Content="{Binding Data.Certificate.sys_org_code,Mode=OneWay}"/>
<misControl:LabelItem Label="所属公司：" Content="{Binding Data.Certificate.sys_company_code,Mode=OneWay}"/>
<misControl:LabelItem Label="流程状态：" Content="{Binding Data.Certificate.bpm_status,Mode=OneWay}"/>
<misControl:LabelItem Label="营运证编号：" Content="{Binding Data.Certificate.certificate_code,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶经营许可证核定的经营范围：" Content="{Binding Data.Certificate.check_area,Mode=OneWay}"/>
<misControl:LabelItem Label="发证机关：" Content="{Binding Data.Certificate.certificate_dept,Mode=OneWay}"/>
<misControl:LabelItem Label="发证日期：">
    <TextBlock Text="{Binding Data.Certificate.release_date,Mode=OneWay,StringFormat='{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
</misControl:LabelItem>
<misControl:LabelItem Label="使用期限至：">
    <TextBlock Text="{Binding Data.Certificate.expiry_date,Mode=OneWay,StringFormat='{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
</misControl:LabelItem>
<misControl:LabelItem Label="证书状态：" Content="{Binding Data.Certificate.status,Mode=OneWay}"/>
<misControl:LabelItem Label="使用期限起：">
    <TextBlock Text="{Binding Data.Certificate.begin_date,Mode=OneWay,StringFormat='{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
</misControl:LabelItem>
