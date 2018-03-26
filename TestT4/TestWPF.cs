
<misControl:LabelItem Label="主键：" Content="{Binding Data.Info.id,Mode=OneWay}"/>
<misControl:LabelItem Label="创建人名称：" Content="{Binding Data.Info.create_name,Mode=OneWay}"/>
<misControl:LabelItem Label="创建人登录名称：" Content="{Binding Data.Info.create_by,Mode=OneWay}"/>
<misControl:LabelItem Label="创建日期：" Content="{Binding Data.Info.create_date,Mode=OneWay,'{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
<misControl:LabelItem Label="更新人名称：" Content="{Binding Data.Info.update_name,Mode=OneWay}"/>
<misControl:LabelItem Label="更新人登录名称：" Content="{Binding Data.Info.update_by,Mode=OneWay}"/>
<misControl:LabelItem Label="更新日期：" Content="{Binding Data.Info.update_date,Mode=OneWay,'{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
<misControl:LabelItem Label="所属部门：" Content="{Binding Data.Info.sys_org_code,Mode=OneWay}"/>
<misControl:LabelItem Label="所属公司：" Content="{Binding Data.Info.sys_company_code,Mode=OneWay}"/>
<misControl:LabelItem Label="流程状态：" Content="{Binding Data.Info.bpm_status,Mode=OneWay}"/>
<misControl:LabelItem Label="申请原因：" Content="{Binding Data.Info.apply_reason,Mode=OneWay}"/>
<misControl:LabelItem Label="申请类型：" Content="{Binding Data.Info.apply_type,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶中文名称：" Content="{Binding Data.Info.chinese_name,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶英文名称：" Content="{Binding Data.Info.english_name,Mode=OneWay}"/>
<misControl:LabelItem Label="沿海内河：" Content="{Binding Data.Info.scope,Mode=OneWay}"/>
<misControl:LabelItem Label="运输主水系类型：" Content="{Binding Data.Info.river_system,Mode=OneWay}"/>
<misControl:LabelItem Label="运输区域：" Content="{Binding Data.Info.area,Mode=OneWay}"/>
<misControl:LabelItem Label="运输类型：" Content="{Binding Data.Info.transport_type,Mode=OneWay}"/>
<misControl:LabelItem Label="是否集装箱班轮运输：" Content="{Binding Data.Info.has_container,Mode=OneWay}"/>
<misControl:LabelItem Label="本船经营范围是否过闸：" Content="{Binding Data.Info.has_sluice,Mode=OneWay}"/>
<misControl:LabelItem Label="曾用名：" Content="{Binding Data.Info.used_name,Mode=OneWay}"/>
<misControl:LabelItem Label="船籍港：" Content="{Binding Data.Info.registry,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶初始登记号：" Content="{Binding Data.Info.first_registration_no,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶登记号：" Content="{Binding Data.Info.registration_no,Mode=OneWay}"/>
<misControl:LabelItem Label="船检登记号：" Content="{Binding Data.Info.check_registration_no,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶识别号：" Content="{Binding Data.Info.check_num,Mode=OneWay}"/>
<misControl:LabelItem Label="运力批文：" Content="{Binding Data.Info.approval_no,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶经营人id：" Content="{Binding Data.Info.operator_id,Mode=OneWay}"/>
<misControl:LabelItem Label="经营人许可证号码：" Content="{Binding Data.Info.operator_license_no,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶所有人：" Content="{Binding Data.Info.owner,Mode=OneWay}"/>
<misControl:LabelItem Label="所占船舶股份：" Content="{Binding Data.Info.ratio,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶管理人id：" Content="{Binding Data.Info.manager_id,Mode=OneWay}"/>
<misControl:LabelItem Label="管理人许可证号码：" Content="{Binding Data.Info.manager_license_no,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶类型：" Content="{Binding Data.Info.ship_type,Mode=OneWay}"/>
<misControl:LabelItem Label="船体材料：" Content="{Binding Data.Info.hull_material,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶总吨：" Content="{Binding Data.Info.total_ton,Mode=OneWay}"/>
<misControl:LabelItem Label="净吨位：" Content="{Binding Data.Info.suttle_ton,Mode=OneWay}"/>
<misControl:LabelItem Label="建成日期：" Content="{Binding Data.Info.build_date,Mode=OneWay,'{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
<misControl:LabelItem Label="改建日期：" Content="{Binding Data.Info.remould_date,Mode=OneWay,'{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
<misControl:LabelItem Label="主机台数：" Content="{Binding Data.Info.mainframe_total_num,Mode=OneWay}"/>
<misControl:LabelItem Label="主机功率：" Content="{Binding Data.Info.mainframe_total_power,Mode=OneWay}"/>
<misControl:LabelItem Label="参考载货量：" Content="{Binding Data.Info.reference_capacity,Mode=OneWay}"/>
<misControl:LabelItem Label="载箱量：" Content="{Binding Data.Info.containe_capacity,Mode=OneWay}"/>
<misControl:LabelItem Label="载车量：" Content="{Binding Data.Info.vehicle_capacity,Mode=OneWay}"/>
<misControl:LabelItem Label="载气量：" Content="{Binding Data.Info.gas_capacity,Mode=OneWay}"/>
<misControl:LabelItem Label="载客定额：" Content="{Binding Data.Info.passenger_capacity,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶来历：" Content="{Binding Data.Info.ship_source,Mode=OneWay}"/>
<misControl:LabelItem Label="总长：" Content="{Binding Data.Info.total_length,Mode=OneWay}"/>
<misControl:LabelItem Label="船长：" Content="{Binding Data.Info.ship_length,Mode=OneWay}"/>
<misControl:LabelItem Label="船宽：" Content="{Binding Data.Info.molded_width,Mode=OneWay}"/>
<misControl:LabelItem Label="型深：" Content="{Binding Data.Info.molded_depth,Mode=OneWay}"/>
<misControl:LabelItem Label="载重吨：" Content="{Binding Data.Info.load_ton,Mode=OneWay}"/>
<misControl:LabelItem Label="是否符合内河尺寸标准：" Content="{Binding Data.Info.has_riverboat_norm,Mode=OneWay}"/>
<misControl:LabelItem Label="本船核定的经营范围：" Content="{Binding Data.Info.check_scope,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶营运证：" Content="{Binding Data.Info.ship_cet_no,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶状态：" Content="{Binding Data.Info.status,Mode=OneWay}"/>
<misControl:LabelItem Label="最近年审年份：" Content="{Binding Data.Info.check_time,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶经营人：" Content="{Binding Data.Info.operator_name,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶管理人：" Content="{Binding Data.Info.manager_name,Mode=OneWay}"/>
<misControl:LabelItem Label="船舶营运证到期时间：" Content="{Binding Data.Info.expire_time,Mode=OneWay,'{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
