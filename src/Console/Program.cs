using System;
using AdventOfCode1016;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;

            // /////////////////////////////////////////////////
            // Day 05
            // /////////////////////////////////////////////////
            input = "cxdnnyjw";
            var password = Day05.FindPassword(input);
            Console.WriteLine($"Day 05");
            Console.WriteLine($"------");
            Console.WriteLine($"Given the actual Door ID <{input}>, the password is {password}");
            Console.WriteLine($"");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");


            // /////////////////////////////////////////////////
            // Day 04
            // /////////////////////////////////////////////////
            
            input = @"bkwzkqsxq-tovvilokx-nozvyiwoxd-172[fstek]
wifilzof-wbiwifuny-yhachyylcha-526[qrazx]
jvyyvzpcl-jhukf-shivyhavyf-487[zhtsi]
kwvacumz-ozilm-kivlg-kwvbiqvumvb-694[gknyw]
mvhkvbdib-kmjezxodgz-mvwwdo-omvdidib-837[dmvbi]
nzydfxpc-rclop-qwzhpc-lnbftdtetzy-171[cptzd]
vhehkyne-unggr-inkvatlbgz-813[gnehk]
tcorcikpi-hnqygt-octmgvkpi-570[nzewo]
xmtjbzidx-wvnfzo-jkzmvodjin-447[uyzlp]
willimcpy-mwupyhayl-bohn-mufym-734[stjoc]
sbejpbdujwf-cvooz-xpsltipq-961[azfnd]
jchipqat-qphzti-rjhidbtg-htgkxrt-271[thigj]
npmhcargjc-zsllw-pcqcypaf-158[mzwnx]
luxciuwncpy-jfumncw-alumm-qilembij-318[mucil]
bxaxipgn-vgpst-rpcsn-rdpixcv-htgkxrth-427[ywazt]
zekvierkzferc-tyftfcrkv-ivtvzmzex-295[evzfk]
enzcntvat-qlr-hfre-grfgvat-143[rtaef]
mvkccspson-bkllsd-nofovyzwoxd-224[oscdk]
enzcntvat-zvyvgnel-tenqr-pnaql-pbngvat-ratvarrevat-429[zymbs]
nwzekwypera-xwogap-pnwejejc-992[lkiwn]
ajmrxjlcren-ajkkrc-lxwcjrwvnwc-667[ezynd]
bxaxipgn-vgpst-hrpktcvtg-wjci-advxhixrh-661[lytku]
owshgfarwv-vqw-kzahhafy-190[ahwfv]
jqwpihizlwca-moo-twoqabqka-512[ncdyv]
apwmeclga-pyzzgr-rcaflmjmew-886[amceg]
tyepcyletzylw-ojp-wzrtdetnd-951[mxqsy]
dlhwvupglk-kfl-hjxbpzpapvu-773[nrotd]
fab-eqodqf-dmnnuf-bgdotmeuzs-612[dchyk]
qjopwxha-bhksan-skngodkl-940[kahno]
lsyrkjkbnyec-dyz-combod-cmkfoxqob-rexd-bomosfsxq-718[lktzs]
zixppfcfba-bdd-jxohbqfkd-939[sqtor]
vxupkizork-kmm-ktmotkkxotm-852[dsqjh]
excdklvo-mkxni-mykdsxq-nozkbdwoxd-952[zspmc]
bnqqnrhud-eknvdq-sqzhmhmf-391[qhndm]
gzefmnxq-otaoaxmfq-ogefayqd-eqdhuoq-716[zinwb]
qzoggwtwsr-qobrm-ghcfous-428[goqrs]
gpbepvxcv-ltpedcxots-qphzti-steadnbtci-193[ignjy]
hvbizodx-nxvqzibzm-cpio-hvmfzodib-265[hixfe]
wkqxodsm-lexxi-kxkvicsc-926[xkcis]
bknsykmdsfo-myxcewob-qbkno-oqq-zebmrkcsxq-380[utqrz]
lejkrscv-wcfnvi-kirzezex-711[ecikr]
htwwtxnaj-idj-btwpxmtu-255[itgmd]
zsxyfgqj-jll-ijufwyrjsy-931[wrpgt]
iuxxuyobk-yigbktmkx-natz-gtgreyoy-384[ygktx]
qjopwxha-xqjju-zalhkuiajp-628[esmxk]
lxaaxbren-ljwmh-anbnjalq-745[stjqy]
gokzyxsjon-zvkcdsm-qbkcc-dbksxsxq-380[tsyqk]
qzoggwtwsr-qobrm-qcohwbu-rsdofhasbh-168[obhqr]
pelbtravp-pnaql-fgbentr-325[pabel]
xzwrmkbqtm-akidmvomz-pcvb-mvoqvmmzqvo-122[mvoqz]
sbnqbhjoh-ezf-fohjoffsjoh-233[xskyb]
jyddc-yrwxefpi-fewoix-hiwmkr-412[pdekg]
fab-eqodqf-rxaiqd-xmnadmfadk-690[sicjl]
xcitgcpixdcpa-rpcsn-htgkxrth-427[stznv]
rflsjynh-rnqnyfwd-lwfij-jll-xytwflj-229[lfjnw]
zotts-wlsiayhcw-vumeyn-fuvilunils-500[ilsun]
odiih-yujbcrl-pajbb-dbna-cnbcrwp-147[bcadi]
udskkaxawv-tmffq-klgjsyw-996[tmnfc]
emixwvqhml-kpwkwtibm-wxmzibqwva-278[zomvn]
dfcxsqhwzs-dzoghwq-ufogg-zcuwghwqg-116[kmijn]
dwbcjkun-ouxfna-mnbrpw-745[nbuwa]
jchipqat-rwdrdapit-pcpanhxh-973[hglvu]
fkqbokxqflkxi-avb-zlkqxfkjbkq-861[wdnor]
wbhsfbohwcboz-foppwh-qighcasf-gsfjwqs-480[fhswb]
dzczkrip-xiruv-szfyrqriuflj-treup-kvtyefcfxp-451[rfipu]
fmsledevhsyw-fyrrc-eguymwmxmsr-698[yzoxu]
udskkaxawv-jsttal-wfyafwwjafy-840[nlkda]
sno-rdbqds-idkkxadzm-sqzhmhmf-287[lngzc]
crwwv-yxphbq-rpbo-qbpqfkd-341[bpqrw]
odiih-mhn-anjlzdrbrcrxw-563[xadcy]
jyddc-ikk-wlmttmrk-698[lmstk]
buzahisl-wshzapj-nyhzz-klzpnu-149[pjxor]
odkasqzuo-eomhqzsqd-tgzf-ymzmsqyqzf-560[frqmp]
gokzyxsjon-bkllsd-yzobkdsyxc-874[nbtmv]
excdklvo-pvygob-bocokbmr-952[tyzxa]
jvsvymbs-jovjvshal-aljouvsvnf-253[zgtdm]
hafgnoyr-qlr-erfrnepu-637[refna]
pelbtravp-sybjre-fnyrf-299[tjoim]
fodvvlilhg-gbh-vwrudjh-621[hvdgl]
kgjgrypw-epybc-bwc-bcnjmwkclr-678[smijy]
myxcewob-qbkno-mrymyvkdo-dbksxsxq-458[bkmox]
joufsobujpobm-fhh-dpoubjonfou-311[uvksy]
rflsjynh-ojqqdgjfs-ijajqturjsy-697[jqsfr]
vetllbybxw-vtgwr-kxtvjnblbmbhg-709[athym]
ajvyjprwp-ajmrxjlcren-kdwwh-lxwcjrwvnwc-433[qsaxt]
zbytomdsvo-mkxni-mykdsxq-myxdksxwoxd-952[xdmko]
esyfwlau-bwddqtwsf-suimakalagf-684[stvip]
jef-iushuj-fhezusjybu-fbqijys-whqii-huiuqhsx-582[uhijs]
tpspahyf-nyhkl-jovjvshal-bzly-alzapun-565[sdprn]
apwmeclga-hcjjwzcyl-umpiqfmn-132[shfrg]
kwtwznct-jcvvg-lmxizbumvb-148[vbcmt]
rmn-qcapcr-aylbw-umpiqfmn-366[juftv]
sorozgxe-mxgjk-hgyqkz-yzuxgmk-748[xuvst]
bkwzkqsxq-wsvsdkbi-qbkno-mkxni-mykdsxq-yzobkdsyxc-822[ksbqx]
ryexqpqhteki-vbemuh-skijecuh-iuhlysu-842[tszmj]
ikhcxvmbex-wrx-wxlbzg-501[zhqis]
lsyrkjkbnyec-mrymyvkdo-nozvyiwoxd-978[enkfi]
wdjcvuvmyjpn-mvhkvbdib-agjrzm-nojmvbz-395[tcxne]
uwtojhynqj-gfxpjy-fhvznxnynts-567[kqpvs]
iqmbazulqp-pkq-dqoquhuzs-534[ntpuq]
gntmfefwitzx-ojqqdgjfs-ijajqturjsy-385[jfqtg]
sebehvkb-fhezusjybu-zubboruqd-husuylydw-972[ytsim]
nzcczdtgp-nsznzwlep-hzcvdsza-405[yotgu]
joufsobujpobm-fhh-ufdiopmphz-675[tsymn]
cxy-bnlanc-snuuhknjw-anbnjalq-823[nabcj]
shoewudys-rkddo-huiuqhsx-374[dhsuo]
vagreangvbany-rtt-jbexfubc-403[ynepo]
aoubshwq-dzoghwq-ufogg-aobousasbh-714[oabgh]
njmjubsz-hsbef-dipdpmbuf-qvsdibtjoh-805[bdjsf]
zovldbkfz-gbiivybxk-lmboxqflkp-653[nyajo]
yknnkoera-xwogap-hkceopeyo-628[ybmzc]
nij-mywlyn-wbiwifuny-guleyncha-396[nyiwl]
ocipgvke-ecpfa-eqcvkpi-vgejpqnqia-258[jsiqz]
encuukhkgf-hnqygt-vgejpqnqia-882[dxzer]
odiih-ljwmh-anbnjalq-927[ahijl]
fkqbokxqflkxi-zxkav-ixyloxqlov-861[nxgja]
udskkaxawv-xmrrq-uzgugdslw-sfsdqkak-216[msfyx]
owshgfarwv-bwddqtwsf-kzahhafy-216[wafhd]
oaxadrgx-dmnnuf-ruzmzouzs-794[uqhse]
ziuxioqvo-akidmvomz-pcvb-zmikycqaqbqwv-616[iqvmo]
bqvvu-xqjju-opknwca-550[yzhum]
xgjougizobk-lruckx-gtgreyoy-670[nbfmk]
bxaxipgn-vgpst-uadltg-bpgztixcv-323[gptxa]
vcibutulxiom-jfumncw-alumm-nluchcha-448[ucmla]
irgyyolokj-xghhoz-uvkxgzouty-930[ogyhk]
kyelcrga-aylbw-amyrgle-umpiqfmn-782[almye]
jsvagsulanw-xdgowj-kzahhafy-138[dblcm]
ixccb-fkrfrodwh-uhdftxlvlwlrq-881[mblzw]
chnylhuncihuf-mwupyhayl-bohn-guleyncha-422[hnuyc]
irdgrxzex-treup-tfrkzex-uvgrikdvek-165[sjbnk]
xzwrmkbqtm-akidmvomz-pcvb-zmikycqaqbqwv-434[sanut]
ykhknbqh-zua-iwjwcaiajp-524[kjlio]
jlidywncfy-mwupyhayl-bohn-uwkocmcncih-916[cyhnw]
nuatmlmdpage-omzpk-eqdhuoqe-326[ljtsm]
xmrrq-kusnwfywj-zmfl-suimakalagf-684[afmkl]
foadouwbu-qvcqczohs-rsgwub-116[oubcq]
etyyx-bgnbnkzsd-kzanqzsnqx-391[pnmlv]
pinovwgz-wvnfzo-hvmfzodib-291[ovzfi]
qekrixmg-gsrwyqiv-kvehi-fewoix-ywiv-xiwxmrk-828[iwxek]
jqwpihizlwca-xtiabqk-oziaa-kcabwumz-amzdqkm-928[aizkm]
qekrixmg-jpsaiv-stivexmsrw-672[etmsq]
excdklvo-gokzyxsjon-mrymyvkdo-bomosfsxq-562[okmsx]
qczcftiz-pibbm-aobousasbh-532[zynvo]
wbhsfbohwcboz-suu-gsfjwqsg-506[bdhxv]
lxwbdvna-pajmn-ajkkrc-anlnrerwp-563[anrjk]
lsyrkjkbnyec-pvygob-cobfsmoc-900[uyrgf]
cqwdujys-sxesebqju-ixyffydw-374[nyjvi]
odiih-ouxfna-anlnrerwp-433[naior]
rzvkjiduzy-xviyt-xjvodib-vxlpdndodji-993[aousd]
ltpedcxots-qphzti-rjhidbtg-htgkxrt-453[rjlkn]
krxqjijamxdb-kdwwh-fxatbqxy-823[wctav]
froruixo-edvnhw-vwrudjh-829[rdhou]
jvyyvzpcl-jhukf-aljouvsvnf-201[uwkic]
nij-mywlyn-vumeyn-zchuhwcha-266[hnycm]
ydjuhdqjyedqb-zubboruqd-tufbeocudj-244[vmkln]
qlm-pbzobq-mixpqfz-doxpp-mrozexpfkd-575[zswni]
qvbmzvibqwvit-moo-tijwzibwzg-330[ibvwz]
pbeebfvir-fpniratre-uhag-freivprf-949[gvxlm]
wfummczcyx-jfumncw-alumm-uwkocmcncih-890[vturj]
dwbcjkun-npp-cajrwrwp-355[kstqo]
dpssptjwf-cbtlfu-vtfs-uftujoh-441[ftsuj]
vrurcjah-pajmn-npp-anbnjalq-303[tozvd]
wfruflnsl-ojqqdgjfs-xfqjx-775[fjqls]
pbafhzre-tenqr-qlr-qrirybczrag-897[yszub]
sehheiylu-rkddo-udwyduuhydw-322[qbyad]
upq-tfdsfu-cbtlfu-nbobhfnfou-103[vpxyh]
ajvyjprwp-npp-dbna-cnbcrwp-901[stevo]
bkzrrhehdc-bzmcx-bnzshmf-qdrdzqbg-833[msuya]
amlqskcp-epybc-aylbw-rcaflmjmew-730[arbyn]
wbhsfbohwcboz-dzoghwq-ufogg-gozsg-272[gobhw]
ksodcbwnsr-dfcxsqhwzs-gqojsbusf-vibh-obozmgwg-194[rwimn]
mfklstdw-usfvq-hmjuzskafy-424[ulgym]
wfruflnsl-ojqqdgjfs-qfgtwfytwd-177[xbofz]
sedikcuh-whqtu-isqludwuh-xkdj-jhqydydw-218[dhuqw]
ltpedcxots-raphhxuxts-qphzti-advxhixrh-765[jahpi]
zgmfyxypbmsq-djmucp-rcaflmjmew-548[aeoiv]
qspkfdujmf-ezf-nbobhfnfou-207[lnkrt]
fbebmtkr-zktwx-pxtihgbsxw-ietlmbv-zktll-kxlxtkva-943[hajmb]
apwmeclga-hcjjwzcyl-bctcjmnkclr-548[yxnzl]
rflsjynh-kqtbjw-btwpxmtu-177[tbjwf]
kfg-jvtivk-treup-uvgcfpdvek-373[vkefg]
upq-tfdsfu-kfmmzcfbo-nbobhfnfou-285[vsglz]
chnylhuncihuf-mwupyhayl-bohn-xypyfijgyhn-266[pwahm]
apwmeclga-zyqicr-dglylagle-886[lagce]
jlidywncfy-xsy-qilembij-188[uxjts]
jqwpihizlwca-lgm-lmaqov-954[laimq]
qcffcgwjs-foppwh-gozsg-246[fgcop]
bqxnfdmhb-rbzudmfdq-gtms-cdrhfm-287[dmbfh]
gifavtkzcv-wcfnvi-rthlzjzkzfe-763[tmniq]
uqtqbizg-ozilm-kivlg-kwibqvo-tijwzibwzg-720[qndzg]
sxdobxkdsyxkv-mkxni-bomosfsxq-848[zyubw]
qfmcusbwq-foppwh-kcfygvcd-662[cfpqw]
sehheiylu-fbqijys-whqii-skijecuh-iuhlysu-660[kdjyq]
sedikcuh-whqtu-uww-bqrehqjeho-660[dtawl]
veqtekmrk-wgezirkiv-lyrx-eguymwmxmsr-464[emrkg]
lqwhuqdwlrqdo-exqqb-uhdftxlvlwlrq-231[ydznk]
sno-rdbqds-bzmcx-otqbgzrhmf-183[gomah]
ujqgywfau-jsttal-hmjuzskafy-476[lghae]
yrwxefpi-jpsaiv-gsrxemrqirx-100[yazxo]
udglrdfwlyh-exqqb-sxufkdvlqj-569[dlqfu]
ugjjgkanw-uzgugdslw-esjcwlafy-736[rnxjs]
pdjqhwlf-sodvwlf-judvv-orjlvwlfv-673[vldfj]
xekdwvwnzkqo-fahhuxawj-ajcejaanejc-524[ajewc]
pwcvonofrcig-pibbm-fsqswjwbu-766[myazu]
tcrjjzwzvu-wcfnvi-glityrjzex-893[bkuyx]
lugjuacha-wbiwifuny-omyl-nymncha-448[mosph]
ckgvutofkj-inuiurgzk-jkvgxzsktz-228[kguzi]
ydjuhdqjyedqb-sqdto-ijehqwu-868[ozqsj]
sxdobxkdsyxkv-zvkcdsm-qbkcc-myxdksxwoxd-640[xdksc]
odkasqzuo-dmnnuf-dqmocgueufuaz-482[wfbke]
wpuvcdng-tcddkv-wugt-vguvkpi-414[hayjs]
lqwhuqdwlrqdo-edvnhw-uhfhlylqj-439[bjzye]
wpuvcdng-dwppa-ceswkukvkqp-674[mxnkj]
qzlozfhmf-bkzrrhehdc-okzrshb-fqzrr-zbpthrhshnm-365[hrzbf]
raphhxuxts-rpcsn-rdpixcv-rjhidbtg-htgkxrt-635[yozvr]
tfejldvi-xiruv-gcrjkzt-xirjj-tljkfdvi-jvimztv-321[veyxs]
ryexqpqhteki-sxesebqju-iqbui-868[qebar]
eqpuwogt-itcfg-hnqygt-tgegkxkpi-648[ywzjl]
uzfqdzmfuazmx-pkq-bgdotmeuzs-482[zmudf]
sbnqbhjoh-cbtlfu-bdrvjtjujpo-441[taquv]
gokzyxsjon-bkwzkqsxq-lexxi-bomosfsxq-354[xoskq]
oazegyqd-sdmpq-iqmbazulqp-dmnnuf-geqd-fqefuzs-456[qdefm]
dwbcjkun-ljwmh-lxjcrwp-anbnjalq-875[hoynm]
udskkaxawv-eadalsjq-yjsvw-xdgowj-klgjsyw-216[cnwyi]
surmhfwloh-exqqb-sxufkdvlqj-439[tspmq]
ksodcbwnsr-foppwh-zcuwghwqg-402[vopuk]
zsxyfgqj-hmthtqfyj-fhvznxnynts-697[fhnty]
yflexwxoalrp-yxphbq-bkdfkbbofkd-653[jzvpm]
ltpedcxots-tvv-rdcipxcbtci-557[ctdip]
slqryzjc-djmucp-qyjcq-756[cjqyd]
rgndvtcxr-qphzti-bpcpvtbtci-817[tcpbi]
ftzgxmbv-fbebmtkr-zktwx-vtgwr-vhtmbgz-lmhktzx-371[wzxvl]
htqtwkzq-hfsid-yjhmstqtld-463[rxszy]
rwcnawjcrxwju-yujbcrl-pajbb-mnenuxyvnwc-979[gkutb]
gokzyxsjon-tovvilokx-kmaescsdsyx-562[dwlah]
iutyaskx-mxgjk-lruckx-iayzuskx-ykxboik-826[kxiuy]
vhglnfxk-zktwx-yehpxk-hixktmbhgl-891[diznt]
sedikcuh-whqtu-kdijqrbu-sqdto-seqjydw-iuhlysui-790[lksjh]
jyfvnlupj-zjhclunly-obua-vwlyhapvuz-617[pirsw]
iuruxlar-sgmtkzoi-hgyqkz-zkinturume-670[qatsn]
wkqxodsm-mrymyvkdo-mecdywob-cobfsmo-250[hgarm]
odiih-kjbtnc-nwprwnnarwp-381[qpodn]
kfg-jvtivk-tyftfcrkv-kirzezex-373[srcvd]
gcfcnuls-aluxy-zotts-wuhxs-omyl-nymncha-552[clnsu]
xmtjbzidx-zbb-xpnojhzm-nzmqdxz-421[mnkio]
qjopwxha-acc-iwngapejc-160[jimst]
emixwvqhml-kivlg-kwibqvo-aitma-564[qspyb]
nvrgfezqvu-avccpsvre-cfxzjkztj-529[lmnsh]
emixwvqhml-ktiaaqnqml-xtiabqk-oziaa-ikycqaqbqwv-746[ozadu]
zhdsrqlchg-hjj-orjlvwlfv-751[hjlrv]
cybyjqho-whqtu-uww-qsgkyiyjyed-478[szxuo]
clxalrtyr-nsznzwlep-wzrtdetnd-405[lnrtz]
sgmtkzoi-yigbktmkx-natz-rghuxgzuxe-722[gktxz]
hjgbwuladw-tskcwl-sfsdqkak-502[txdsw]
yrwxefpi-hci-vigimzmrk-646[hdmzy]
hqcfqwydw-hqrryj-jusxdebewo-946[qwdeh]
wsvsdkbi-qbkno-cmkfoxqob-rexd-yzobkdsyxc-276[wptxs]
qfmcusbwq-qvcqczohs-zcuwghwqg-870[mnybx]
clxalrtyr-nsznzwlep-cpdplcns-743[rtycz]
fbebmtkr-zktwx-ktuubm-ybgtgvbgz-553[osmdy]
jvuzbtly-nyhkl-yhtwhnpun-jovjvshal-ylzlhyjo-773[hlyjn]
slqryzjc-aylbw-pcacgtgle-782[nxkri]
tfcfiwlc-wcfnvi-wzeretzex-971[smobe]
jef-iushuj-uww-qsgkyiyjyed-556[xzrwq]
crwwv-yxphbq-xkxivpfp-653[pxvwb]
hqcfqwydw-zubboruqd-husuylydw-244[lqeho]
oxmeeuruqp-qss-eqdhuoqe-534[equos]
qxdwpopgsdjh-rgndvtcxr-gpqqxi-gthtpgrw-687[gpdqr]
mybbycsfo-mrymyvkdo-bocokbmr-692[pymza]
myvybpev-oqq-yzobkdsyxc-250[sxytw]
fnjyxwrinm-kdwwh-uxprbcrlb-329[natqu]
aietsrmdih-nippcfier-gsrxemrqirx-958[iremp]
xmrrq-tmffq-vwhdgqewfl-138[fqmrw]
oqnidbshkd-bzmcx-sdbgmnknfx-599[nzdyx]
eqttqukxg-ecpfa-eqcvkpi-ewuvqogt-ugtxkeg-128[mytkp]
nchhg-ntwemz-amzdqkma-252[kmbop]
bjfutsneji-jll-zxjw-yjxynsl-775[ndbsw]
ktwbhtvmbox-lvtoxgzxk-angm-mxvaghehzr-319[ijqxb]
kyelcrga-afmamjyrc-pcqcypaf-210[acyfm]
myxcewob-qbkno-mkxni-oxqsxoobsxq-484[oxbqk]
esyfwlau-vqw-kzahhafy-788[jikae]
oqnidbshkd-eknvdq-btrsnldq-rdquhbd-391[njzml]
qjopwxha-bhksan-opknwca-888[ahkno]
udskkaxawv-jsttal-vwhdgqewfl-190[hqmnt]
excdklvo-lexxi-crszzsxq-458[uavnl]
frqvxphu-judgh-fdqgb-frdwlqj-wudlqlqj-179[bimaq]
iuruxlar-kmm-ykxboiky-852[tijpz]
tyepcyletzylw-mldvpe-lylwjdtd-509[lydet]
frqvxphu-judgh-gbh-whfkqrorjb-101[mhbes]
xqvwdeoh-edvnhw-zrunvkrs-699[zmudw]
irdgrxzex-treup-fgvirkzfej-893[fbsyn]
cxy-bnlanc-ljwmh-orwjwlrwp-771[ngpmz]
eqpuwogt-itcfg-gii-ucngu-388[hzgae]
ikhcxvmbex-cxeeruxtg-wxlbzg-553[mvnfs]
mrxivrexmsrep-fyrrc-asvowlst-854[codsq]
npmhcargjc-aylbw-qcptgacq-366[ditsg]
ftzgxmbv-ietlmbv-zktll-phkdlahi-241[ltbhi]
hqcfqwydw-tou-bewyijysi-270[hnvux]
emixwvqhml-kivlg-abwziom-590[imlvw]
pejji-nio-mecdywob-cobfsmo-926[wrjmp]
bknsykmdsfo-oqq-dbksxsxq-640[naysz]
gifavtkzcv-vxx-tfekrzedvek-789[cnwtp]
kmjezxodgz-diozmivodjivg-agjrzm-xjiovdihzio-915[yqktj]
shoewudys-vbemuh-qsgkyiyjyed-946[nqsjd]
htqtwkzq-ojqqdgjfs-rfwpjynsl-749[hryqo]
rmn-qcapcr-zyqicr-pcacgtgle-340[znstw]
bnqqnrhud-bzmcx-bnmszhmldms-729[yfetv]
surmhfwloh-gbh-rshudwlrqv-725[dsaym]
jchipqat-tvv-itrwcdadvn-505[povhu]
zgmfyxypbmsq-njyqrga-epyqq-rcaflmjmew-340[mqyae]
froruixo-exqqb-pdunhwlqj-283[nmuqd]
lnkfaypeha-xwogap-odellejc-784[ytrsz]
jlidywncfy-xsy-fuvilunils-864[ilyfn]
joufsobujpobm-dipdpmbuf-sftfbsdi-545[rwjnm]
tvsnigxmpi-gerhc-gsexmrk-eguymwmxmsr-932[pivem]
tfejldvi-xiruv-srjbvk-ivjvrity-815[vijrt]
zuv-ykixkz-yigbktmkx-natz-zkinturume-410[kzitu]
enzcntvat-pubpbyngr-qrcyblzrag-117[oywbs]
wsvsdkbi-qbkno-lkcuod-nofovyzwoxd-744[xnuqc]
wbhsfbohwcboz-foppwh-aobousasbh-246[nfsml]
uiovmbqk-jcvvg-abwziom-720[nbqaz]
etaqigpke-fag-fgrnqaogpv-674[gaefp]
ejpanjwpekjwh-nwxxep-hkceopeyo-238[bmscu]
qjopwxha-bhksan-wjwhuoeo-940[xenwh]
etyyx-bzmcx-bnzshmf-qdzbpthrhshnm-729[hbmzn]
uqtqbizg-ozilm-lgm-abwziom-356[tspmz]
excdklvo-mybbycsfo-tovvilokx-psxkxmsxq-874[axwon]
mvydjvxodqz-xviyt-xjvodib-pnzm-oznodib-187[nflym]
ixccb-zhdsrqlchg-edvnhw-xvhu-whvwlqj-465[hcvwd]
qspkfdujmf-votubcmf-tdbwfohfs-ivou-bdrvjtjujpo-181[esuzg]
fkqbokxqflkxi-qlm-pbzobq-bdd-jxohbqfkd-601[dcgym]
mtzslklcozfd-prr-nfdezxpc-dpcgtnp-301[tmnrk]
xekdwvwnzkqo-lhwopey-cnwoo-wymqeoepekj-290[rzsnk]
fubrjhqlf-sodvwlf-judvv-pdqdjhphqw-725[dfhjq]
shoewudys-zubboruqd-skijecuh-iuhlysu-608[ushbd]
zlkprjbo-doxab-zxkav-rpbo-qbpqfkd-679[bkopa]
nzcczdtgp-mldvpe-opawzjxpye-587[tkbms]
apuut-nxvqzibzm-cpio-yzkvmohzio-655[rsozd]
rgllk-ngzzk-ymdwqfuzs-300[yhzxu]
cvabijtm-jcvvg-uiviomumvb-538[ixajz]
oazegyqd-sdmpq-otaoaxmfq-pqbmdfyqzf-248[qadfm]
rtqlgevkng-fag-nqikuvkeu-960[nqdom]
bnknqetk-cxd-cdrhfm-183[mfpwa]
ohmnuvfy-wuhxs-wiuncha-lyuwkocmcncih-552[chunw]
hqtyeqsjylu-jef-iushuj-tou-fkhsxqiydw-296[isfmy]
kwtwznct-kwvacumz-ozilm-jiasmb-uiviomumvb-746[qmjyz]
qfmcusbwq-foppwh-twbobqwbu-298[bwqfo]
ykhknbqh-xqjju-owhao-472[hjtck]
dszphfojd-tdbwfohfs-ivou-mbcpsbupsz-103[sbdfo]
lahxpnwrl-ljwmh-nwprwnnarwp-641[srtpm]
ckgvutofkj-lruckx-jkvruesktz-878[zjlyk]
dyz-combod-zvkcdsm-qbkcc-nocsqx-926[yvute]
ktwbhtvmbox-wrx-nlxk-mxlmbgz-345[lsuwt]
nwilwcejc-nwxxep-zalhkuiajp-186[bznxr]
uzfqdzmfuazmx-otaoaxmfq-bgdotmeuzs-846[mzafo]
oxmeeuruqp-omzpk-oamfuzs-oazfmuzyqzf-352[ypdzg]
zhdsrqlchg-fdqgb-ghsduwphqw-361[hdgqs]
nchhg-jiasmb-amzdqkma-278[qklti]
tfiifjzmv-upv-wzeretzex-295[itvos]
eqttqukxg-ecpfa-ujkrrkpi-830[kepqr]
clotzlnetgp-mldvpe-nzyeltyxpye-145[xfpsy]
mbiyqoxsm-myvybpev-mkxni-mykdsxq-yzobkdsyxc-900[ymxbk]
plolwdub-judgh-vfdyhqjhu-kxqw-vhuylfhv-621[zqwmy]
atyzghrk-vxupkizork-jek-giwaoyozout-228[abrmv]
zotts-xsy-mufym-162[mstyf]
vhehkyne-ktuubm-mktbgbgz-293[qmytr]
kwvacumz-ozilm-zijjqb-ivitgaqa-616[fkoxt]
yaxsnlcrun-ajvyjprwp-snuuhknjw-anlnrerwp-771[zpyld]
raphhxuxts-bpvctixr-eaphixr-vgphh-bpcpvtbtci-115[phtxb]
nuatmlmdpage-odkasqzuo-qss-dqmocgueufuaz-768[umnqw]
yknnkoera-lhwopey-cnwoo-nawymqeoepekj-680[eonkw]
pybgmyargtc-aylbw-qyjcq-886[buzfp]
gzefmnxq-ngzzk-iadwetab-638[zaegn]
sbnqbhjoh-kfmmzcfbo-usbjojoh-129[acdkb]
lxaaxbren-lujbbrornm-ljwmh-lxjcrwp-mnyjacvnwc-355[yzsuk]
nchhg-lgm-nqvivkqvo-200[dystz]
plolwdub-judgh-udeelw-rshudwlrqv-335[sihdt]
wlsiayhcw-vumeyn-lymyulwb-292[zbrux]
ytu-xjhwjy-hfsid-htfynsl-qtlnxynhx-411[adxmu]
wkqxodsm-tovvilokx-ckvoc-822[uhgov]
chnylhuncihuf-vumeyn-nluchcha-500[rcbmn]
tfiifjzmv-lejkrscv-tyftfcrkv-jyzggzex-243[fjtvz]
eqpuwogt-itcfg-tcddkv-tgugctej-310[pyemh]
iuruxlar-xgsvgmotm-pkrrehkgt-xkykgxin-956[btwqp]
shoewudys-sxesebqju-qdqboiyi-894[seqbd]
zlkprjbo-doxab-gbiivybxk-pxibp-861[azyjx]
ckgvutofkj-inuiurgzk-lotgtiotm-982[qszly]
thnulapj-jshzzpmplk-jhukf-vwlyhapvuz-747[hpjlu]
pybgmyargtc-hcjjwzcyl-qcptgacq-782[bxsuc]
xgsvgmotm-vrgyzoi-mxgyy-iutzgotsktz-150[gtmoy]
laffe-yigbktmkx-natz-jkyomt-696[ktafm]
zvyvgnel-tenqr-pubpbyngr-znexrgvat-507[wfjhu]
pelbtravp-pnaql-znantrzrag-403[cbyja]
jqwpihizlwca-akidmvomz-pcvb-apqxxqvo-850[oxymv]
cvabijtm-ntwemz-twoqabqka-954[atbmq]
zixppfcfba-avb-zlkqxfkjbkq-809[zlmjc]
sebehvkb-zubboruqd-tufqhjcudj-556[budeh]
lqwhuqdwlrqdo-fdqgb-ghvljq-621[qdlgh]
qlm-pbzobq-crwwv-zxkav-zlxqfkd-rpbo-qbpqfkd-731[ciyxw]
pwcvonofrcig-gqojsbusf-vibh-qighcasf-gsfjwqs-740[csebm]
mvydjvxodqz-kmjezxodgz-kgvnodx-bmvnn-yzqzgjkhzio-239[zdovg]
kzgwomvqk-xtiabqk-oziaa-tijwzibwzg-564[menyj]
ksodcbwnsr-xszzmpsob-kcfygvcd-454[mbaod]
ejpanjwpekjwh-xwogap-hwxknwpknu-472[wpjkn]
mvydjvxodqz-hvbizodx-wpiit-hvivbzhzio-967[ivzdh]
mvydjvxodqz-mvwwdo-nzmqdxzn-681[jryzk]
enqvbnpgvir-rtt-freivprf-871[lgqrc]
hvbizodx-wpiit-kpmxcvndib-291[dyjmn]
molgbzqfib-mixpqfz-doxpp-xkxivpfp-965[pxfib]
fbebmtkr-zktwx-cxeeruxtg-nlxk-mxlmbgz-137[dckut]
luxciuwncpy-luvvcn-mbcjjcha-500[qsvzt]
apwmeclga-hcjjwzcyl-qyjcq-704[cjalq]
wpuvcdng-eqttqukxg-uecxgpigt-jwpv-cpcnauku-830[ucgpt]
iehepwnu-cnwza-fahhuxawj-pnwejejc-940[ewahj]
pbybeshy-pbeebfvir-pnaql-pbngvat-freivprf-715[uyzwp]
htsxzrjw-lwfij-ojqqdgjfs-zxjw-yjxynsl-957[iyonc]
sxdobxkdsyxkv-wsvsdkbi-qbkno-zvkcdsm-qbkcc-bomosfsxq-536[mbyan]
fruurvlyh-fkrfrodwh-uhdftxlvlwlrq-335[rflhu]
froruixo-hjj-orjlvwlfv-387[uyawn]
myvybpev-lexxi-vklybkdybi-978[ybvei]
chnylhuncihuf-vohhs-xymcah-240[yxnmh]
tagzsrsjvgmk-vqw-vwhsjlewfl-606[svwgj]
zbytomdsvo-lexxi-domrxyvyqi-250[oxydi]
qfkkj-clmmte-opgpwzaxpye-821[pekma]
lgh-kwujwl-udskkaxawv-jsttal-hmjuzskafy-320[axyrm]
irdgrxzex-nvrgfezqvu-avccpsvre-cfxzjkztj-191[sclzh]
mhi-lxvkxm-xzz-etuhktmhkr-319[rcomn]
lhkhszqx-fqzcd-dff-sdbgmnknfx-391[ugevx]
apwmeclga-aylbw-ylyjwqgq-314[izfye]
yflexwxoalrp-zlkprjbo-doxab-ciltbo-qbzeklildv-341[byclp]
cvabijtm-kwzzwaqdm-ntwemz-abwziom-252[rdmvn]
qfkkj-upwwjmply-epnsyzwzrj-899[okhgz]
jxdkbqfz-avb-zlkqxfkjbkq-861[wptxb]
gpsxdprixkt-qphzti-hwxeexcv-947[krgwe]
nij-mywlyn-wuhxs-wiuncha-lymyulwb-968[wylnu]
sbnqbhjoh-kfmmzcfbo-ufdiopmphz-987[bfhmo]
guahyncw-jfumncw-alumm-xyjfisgyhn-500[htamn]
ytu-xjhwjy-jll-ijxnls-879[duthg]
lgh-kwujwl-usfvq-ugslafy-esfsywewfl-944[ilszy]
tvsnigxmpi-tpewxmg-kveww-xiglrspskc-152[gipsw]
joufsobujpobm-cbtlfu-dvtupnfs-tfswjdf-129[fubjo]
rwcnawjcrxwju-bljenwpna-qdwc-mnyuxhvnwc-225[wncja]
qzchnzbshud-okzrshb-fqzrr-rzkdr-989[rzhbd]
qzoggwtwsr-pogysh-rsjszcdasbh-896[sghor]
gzefmnxq-dmnnuf-xmnadmfadk-326[tvuiw]
qzoggwtwsr-pibbm-zopcfohcfm-792[jsmfu]
mvydjvxodqz-xviyt-xjvodib-hvivbzhzio-369[iceny]
wkqxodsm-lkcuod-cdybkqo-224[dkocq]
veqtekmrk-ikk-wxsveki-542[keivm]
zlkprjbo-doxab-yxphbq-pqloxdb-419[ckdtm]
buzahisl-ibuuf-klzpnu-721[stjnm]
hwdtljsnh-kqtbjw-ijajqturjsy-515[plnqy]
luxciuwncpy-jfumncw-alumm-lyuwkocmcncih-474[lqpco]
tinnm-ibghopzs-rms-aobousasbh-506[sboah]
pbeebfvir-rtt-ratvarrevat-403[tdokj]
dmybmsuzs-pkq-efadmsq-300[msdqa]
ujqgywfau-tmffq-dgyaklauk-970[yxmid]
ovbunmneqbhf-enoovg-hfre-grfgvat-481[efgno]
hqfxxnknji-kzeed-uqfxynh-lwfxx-wjhjnansl-957[nxfhj]
plolwdub-judgh-edvnhw-pdqdjhphqw-985[dsxhg]
nwlddtqtpo-awldetn-rcldd-nfdezxpc-dpcgtnp-353[dnptc]
bwx-amkzmb-xzwrmkbqtm-ntwemz-amzdqkma-668[swmnl]
bqxnfdmhb-qzaahs-rdquhbdr-443[bdhqa]
egdytrixat-ide-htrgti-uadltg-steadnbtci-297[zampy]
gsrwyqiv-kvehi-gerhc-gsexmrk-erepcwmw-880[bkwts]
nsyjwsfyntsfq-gfxpjy-jslnsjjwnsl-749[lvzus]
dfcxsqhwzs-pibbm-gvwddwbu-246[dqbem]
mtzslklcozfd-ojp-fdpc-epdetyr-613[dpcef]
gbc-frperg-ohaal-erfrnepu-351[reafg]
gvaaz-cbtlfu-efqbsunfou-311[dvnmz]
ugdgjxmd-tskcwl-umklgewj-kwjnauw-892[wgjku]
iruzfrtkzmv-avccpsvre-nfibjyfg-243[jzoyc]
shoewudys-hqrryj-bqrehqjeho-296[heqrj]
hwdtljsnh-kqtbjw-htsyfnsrjsy-827[dntpc]
zilqwikbqdm-kivlg-uiviomumvb-902[imvbk]
rsvxltspi-sfnigx-wxsveki-984[sixve]
surmhfwloh-gbh-xvhu-whvwlqj-387[hwluv]
ubhatstkwhnl-yehpxk-wxlbzg-137[raqjb]
oknkvcta-itcfg-uecxgpigt-jwpv-ocpcigogpv-596[cgpio]
amjmpdsj-djmucp-nspafyqgle-470[ztpqn]
zixppfcfba-avb-abpfdk-471[abfpc]
owshgfarwv-jsttal-vwkayf-944[smcyx]
vjpwncrl-ljwmh-lxjcrwp-lxwcjrwvnwc-589[irbxq]
qvbmzvibqwvit-ziuxioqvo-lgm-amzdqkma-928[hgfln]
lxuxaodu-kjbtnc-jwjuhbrb-147[bjuxa]
etaqigpke-fag-yqtmujqr-440[qaegt]
zekvierkzferc-irdgrxzex-jtrmvexvi-ylek-rthlzjzkzfe-633[gkyzp]
mfklstdw-hdsklau-yjskk-kwjnauwk-762[vnfzg]
pkl-oaynap-fahhuxawj-oanreyao-706[mdfpn]
hwdtljsnh-hmthtqfyj-rfsfljrjsy-359[sxziu]
fab-eqodqf-ngzzk-bgdotmeuzs-144[kxags]
tagzsrsjvgmk-tskcwl-vwhsjlewfl-424[ejuah]
kzgwomvqk-jiasmb-uizsmbqvo-590[mbiko]
qjopwxha-xqjju-oanreyao-758[ubmon]
hvbizodx-xmtjbzidx-nxvqzibzm-cpio-yzkgjthzio-889[rmyqo]
iuruxlar-kmm-jkvruesktz-644[kruma]
ujqgywfau-jsttal-vwhdgqewfl-710[hbdlx]
jlidywncfy-wuhxs-wiuncha-yhachyylcha-630[hycaw]
lugjuacha-wlsiayhcw-dyffsvyuh-uhufsmcm-890[juefh]
hjgbwuladw-xdgowj-hmjuzskafy-398[wqigl]
yuxufmdk-sdmpq-pkq-etubbuzs-456[wldkg]
vcibutulxiom-dyffsvyuh-qilembij-110[jdnmz]
nzwzcqfw-clmmte-dpcgtnpd-509[cdmnp]
aczupnetwp-nlyoj-nzletyr-zapcletzyd-665[zelnp]
htsxzrjw-lwfij-wfintfhynaj-kqtbjw-knsfshnsl-983[kytzm]
enqvbnpgvir-onfxrg-qrirybczrag-611[rgnbi]
molgbzqfib-ciltbo-xkxivpfp-159[biflo]
plolwdub-judgh-fkrfrodwh-ghyhorsphqw-517[hdorw]
gzefmnxq-omzpk-oazfmuzyqzf-872[zkycu]
qjopwxha-lhwopey-cnwoo-naoawnyd-186[cvyno]
jyfvnlupj-ipvohghykvbz-jovjvshal-ylzlhyjo-435[xlenk]
ajmrxjlcren-kjbtnc-jwjuhbrb-329[klcuz]
wdjcvuvmyjpn-ezggtwzvi-jkzmvodjin-603[gmveh]
muqfedyput-fbqijys-whqii-bqrehqjeho-192[vdlge]
ktfitzbgz-xzz-ftgtzxfxgm-605[izfql]
bknsykmdsfo-oqq-wkbuodsxq-458[stifb]
slqryzjc-hcjjwzcyl-yaosgqgrgml-314[qymir]
gpewwmjmih-veffmx-xvemrmrk-126[itcvu]
rdadguja-gpqqxi-ldgzhwde-297[hnvso]
lxaaxbren-mhn-cnlqwxuxph-251[xvjuz]
xst-wigvix-fewoix-gsrxemrqirx-698[xireg]
iehepwnu-cnwza-zua-wymqeoepekj-108[sdnmj]
oknkvcta-itcfg-rncuvke-itcuu-hkpcpekpi-908[pgfbe]
enqvbnpgvir-ohaal-hfre-grfgvat-351[hsgdf]
ixccb-iorzhu-hqjlqhhulqj-647[hqcij]
apuut-agjrzm-jkzmvodjin-915[jamuz]
hqcfqwydw-rqiauj-ijehqwu-530[qwhij]
vhehkyne-ktwbhtvmbox-lvtoxgzxk-angm-kxvxbobgz-683[tsurp]
gntmfefwitzx-idj-knsfshnsl-723[fnsit]
ajvyjprwp-bljenwpna-qdwc-ujkxajcxah-563[yskxv]
joufsobujpobm-dboez-dpbujoh-mbcpsbupsz-259[bopuj]
xlrypetn-prr-nzyeltyxpye-847[yeprl]
zuv-ykixkz-xgsvgmotm-lruckx-jkvgxzsktz-696[ijlfz]
jqwpihizlwca-moo-lmxtwgumvb-798[nkzsr]
jsvagsulanw-kusnwfywj-zmfl-klgjsyw-736[ectrq]
ykhknbqh-nwxxep-nawymqeoepekj-758[cfvdy]
kzeed-gfxpjy-tujwfyntsx-385[aunmy]
slqryzjc-qaytclecp-fslr-dglylagle-184[lcyae]
laffe-vrgyzoi-mxgyy-iutzgotsktz-410[gtyzf]
gpbepvxcv-hrpktcvtg-wjci-stktadebtci-141[zoqhx]
yaxsnlcrun-lqxlxujcn-mnyuxhvnwc-641[nxclu]
tagzsrsjvgmk-kusnwfywj-zmfl-dstgjslgjq-294[gayon]
kwzzwaqdm-zijjqb-xczkpiaqvo-902[mkgjt]
mfklstdw-usfvq-ugslafy-xafsfuafy-684[fsaul]
zvyvgnel-tenqr-ovbunmneqbhf-sybjre-fgbentr-117[shfce]
emixwvqhml-akidmvomz-pcvb-amzdqkma-720[relbk]
rdggdhxkt-eaphixr-vgphh-hwxeexcv-973[xozyv]
bqvvu-zua-iwngapejc-992[nmdax]
bjfutsneji-kqtbjw-wjxjfwhm-203[irjmx]
bdavqofuxq-nmewqf-abqdmfuaze-976[vgzhc]
vdzonmhydc-okzrshb-fqzrr-rzkdr-313[rzdhk]
sawlkjevaz-oywrajcan-dqjp-wjwhuoeo-836[ajwoe]
fruurvlyh-gbh-sxufkdvlqj-413[kftmo]
fruurvlyh-sodvwlf-judvv-ghsorbphqw-569[tadzk]
sbejpbdujwf-tdbwfohfs-ivou-dpoubjonfou-103[rbqio]
oxmeeuruqp-otaoaxmfq-xasuefuoe-222[ozipy]
rdggdhxkt-qphzti-ejgrwphxcv-921[tusrb]
dkqjcbctfqwu-fag-yqtmujqr-882[kzvuf]
gzefmnxq-dmnnuf-mzmxkeue-248[menfu]
kgjgrypw-epybc-aylbw-kylyeckclr-314[mlvhs]
bwx-amkzmb-akidmvomz-pcvb-abwziom-148[nmtyw]
ckgvutofkj-sorozgxe-mxgjk-xghhoz-xkykgxin-670[gkxoh]
zhdsrqlchg-fkrfrodwh-ghsorbphqw-803[cjybd]
hvbizodx-wvnfzo-adivixdib-603[xwstz]
tvsnigxmpi-gerhc-hitpscqirx-204[icghp]
jrncbavmrq-cynfgvp-tenff-npdhvfvgvba-741[ybszn]
mbiyqoxsm-pvygob-psxkxmsxq-952[mjfnc]
gsrwyqiv-kvehi-veffmx-gywxsqiv-wivzmgi-282[bdrgj]
clxalrtyr-xtwtelcj-rclop-awldetn-rcldd-cpdplcns-847[lcdrt]
ahngzyzqcntr-bzmcx-sdbgmnknfx-287[fmyqt]
zgmfyxypbmsq-aylbw-amyrgle-bctcjmnkclr-340[mybcl]
fydelmwp-prr-nzyeltyxpye-717[gfjxa]
rnqnyfwd-lwfij-rflsjynh-wfggny-xfqjx-931[fnjwy]
zilqwikbqdm-xtiabqk-oziaa-twoqabqka-278[ftonr]
bjfutsneji-gzssd-uzwhmfxnsl-827[sfjnu]
ojk-nzxmzo-pinovwgz-agjrzm-jkzmvodjin-733[zjomn]
ygcrqpkbgf-dcumgv-fgukip-570[vmhxn]
dzczkrip-xiruv-srjbvk-jyzggzex-945[uzneh]
bkzrrhehdc-bzmcx-lzmzfdldms-287[eclvd]
ziuxioqvo-kpwkwtibm-lmxizbumvb-564[txsru]
kzgwomvqk-lgm-lmxizbumvb-122[mbgkl]
htsxzrjw-lwfij-idj-xjwanhjx-463[obdze]
gntmfefwitzx-kqtbjw-wjxjfwhm-749[qzutv]
htsxzrjw-lwfij-jll-tujwfyntsx-671[xugan]
ymszqfuo-rxaiqd-etubbuzs-118[ubqsz]
vdzonmhydc-azrjds-lzqjdshmf-989[dzhjm]
dyz-combod-bkllsd-oxqsxoobsxq-354[nrmkx]
pyknyegle-afmamjyrc-yaosgqgrgml-626[zdlfg]
oxmeeuruqp-vqxxknqmz-oazfmuzyqzf-352[rnsyt]
qjopwxha-xqjju-pnwejejc-654[jepqw]
wifilzof-jfumncw-alumm-xypyfijgyhn-604[fjerw]
vagreangvbany-enoovg-fuvccvat-533[gncot]
avw-zljyla-zjhclunly-obua-thuhnltlua-669[wathd]
ynssr-lvtoxgzxk-angm-mxvaghehzr-345[vopnm]
cvabijtm-uqtqbizg-ozilm-xtiabqk-oziaa-lmdmtwxumvb-928[imabt]
frqvxphu-judgh-sodvwlf-judvv-pdqdjhphqw-751[azovy]
qmpmxevc-kvehi-jyddc-fyrrc-qerekiqirx-282[ygmhv]
fodvvlilhg-udeelw-pdunhwlqj-153[sndmo]
gpsxdprixkt-ytaanqtpc-gthtpgrw-765[tpgar]
cvabijtm-kpwkwtibm-bmkpvwtwog-174[wbkmt]
vetllbybxw-yehpxk-wxlbzg-891[yekxl]
nzwzcqfw-nlyoj-dezclrp-275[zclnw]
qmpmxevc-kvehi-glsgspexi-gsrxemrqirx-828[exgim]
xtwtelcj-rclop-dnlgpyrpc-sfye-hzcvdsza-873[xmpon]
jrncbavmrq-pnaql-jbexfubc-793[bacjn]
ohmnuvfy-yaa-lymyulwb-266[yalmu]
nzwzcqfw-aczupnetwp-awldetn-rcldd-pyrtyppctyr-613[pctwd]
vqr-ugetgv-uecxgpigt-jwpv-rwtejcukpi-752[geptu]
tfcfiwlc-lejkrscv-upv-rthlzjzkzfe-607[tcfns]
hwdtljsnh-uqfxynh-lwfxx-knsfshnsl-229[xtngb]
iuruxlar-igtje-iayzuskx-ykxboik-930[kmghr]
xjgjmapg-ezggtwzvi-hvivbzhzio-421[gzivh]
gpbepvxcv-hrpktcvtg-wjci-hwxeexcv-349[xswrp]
tcorcikpi-eqttqukxg-gii-hkpcpekpi-622[ruxyk]
ygcrqpkbgf-ejqeqncvg-ucngu-440[gcqen]
etyyx-dff-qdbdhuhmf-729[wskto]
tfiifjzmv-upv-vexzevvizex-399[veizf]
houngfgxjuay-sorozgxe-mxgjk-jek-aykx-zkyzotm-566[aimhd]
hcd-gsqfsh-dzoghwq-ufogg-aobousasbh-714[ynfie]
foadouwbu-qobrm-qcohwbu-zopcfohcfm-792[obcfu]
ynukcajey-oywrajcan-dqjp-wjwhuoeo-680[jaowy]
rflsjynh-jll-rfsfljrjsy-489[jlfrs]
vkrhzxgbv-pxtihgbsxw-yehpxk-mktbgbgz-917[igtvy]
hjgbwuladw-tskcwl-dgyaklauk-294[aklwd]
cvabijtm-jcvvg-zmikycqaqbqwv-772[vcqab]
odiih-yujbcrl-pajbb-vjwjpnvnwc-849[jbcin]
tinnm-tzcksf-igsf-hsghwbu-220[bnamt]
pbeebfvir-wryylorna-jbexfubc-637[egouk]
xmtjbzidx-xviyt-yzqzgjkhzio-265[vxsry]
avw-zljyla-zjhclunly-obua-klwhyatlua-201[sjayl]
dfcxsqhwzs-qvcqczohs-fsgsofqv-246[dosrp]
rzvkjiduzy-xviyt-xjvodib-kpmxcvndib-291[cwzla]
gcfcnuls-aluxy-mwupyhayl-bohn-wihnuchgyhn-968[hnuyc]
dyz-combod-lsyrkjkbnyec-bkllsd-domrxyvyqi-328[vtxzd]
fruurvlyh-mhoobehdq-dftxlvlwlrq-907[jlves]
mrxivrexmsrep-gerhc-gsexmrk-tyvglewmrk-152[wzuly]
votubcmf-gmpxfs-pqfsbujpot-883[fpbmo]
bljenwpna-qdwc-anbnjalq-329[lcwmy]
xekdwvwnzkqo-ydkykhwpa-wjwhuoeo-550[toavy]
yhkpvhjapcl-yhiipa-jbzavtly-zlycpjl-201[lpyah]
xjinphzm-bmvyz-wvnfzo-nzmqdxzn-681[ykfxe]
pbeebfvir-rtt-ybtvfgvpf-507[bftve]
gvcskirmg-ikk-hizipstqirx-750[iyquj]
yhwooebeaz-lhwopey-cnwoo-oanreyao-108[tmuag]
wlqqp-jtrmvexvi-ylek-nfibjyfg-581[tnrhf]
tfiifjzmv-avccpsvre-jyzggzex-477[mvnjr]
xjmmjndqz-zbb-yzndbi-811[bzdjm]
qjopwxha-xwogap-nayaerejc-160[isjqz]
qzlozfhmf-azrjds-knfhrshbr-573[dfmys]
vhglnfxk-zktwx-vetllbybxw-vtgwr-vhtmbgz-ybgtgvbgz-761[gbtvl]
etaqigpke-ecpfa-eqcvkpi-cpcnauku-336[eyxtb]
lqwhuqdwlrqdo-fdqgb-frdwlqj-zrunvkrs-933[tvijl]
gvcskirmg-tvsnigxmpi-gerhc-gsexmrk-wlmttmrk-828[szawg]
irdgrxzex-kfg-jvtivk-wcfnvi-jyzggzex-269[givxz]
cqwdujys-sqdto-iqbui-270[siyeh]
bnqqnrhud-bgnbnkzsd-trdq-sdrshmf-807[dnbqr]
rgndvtcxr-hrpktcvtg-wjci-prfjxhxixdc-193[yjsht]
qekrixmg-hci-xvemrmrk-282[mreik]
xcitgcpixdcpa-snt-apqdgpidgn-349[mfywv]
wkqxodsm-pvygob-wkbuodsxq-978[ysamp]
aoubshwq-qvcqczohs-kcfygvcd-558[ytvls]
tyepcyletzylw-qwzhpc-opalcexpye-301[gamdn]
tfcfiwlc-treup-uvjzxe-607[nrthm]
ubhatstkwhnl-lvtoxgzxk-angm-inkvatlbgz-865[tagkl]
wihmogyl-aluxy-yaa-qilembij-890[emvct]
bxaxipgn-vgpst-ltpedcxots-gpqqxi-hidgpvt-245[pgtxi]
jfifqxov-doxab-mixpqfz-doxpp-obpbxoze-107[ghpyi]
gvaaz-dpssptjwf-sbccju-fohjoffsjoh-675[pfzwa]
gzefmnxq-eomhqzsqd-tgzf-efadmsq-378[qefmz]
emixwvqhml-kivlg-zmkmqdqvo-876[dcfin]
fodvvlilhg-fdqgb-frqwdlqphqw-725[qdflg]
laffe-pkrrehkgt-rumoyzoiy-670[dyjut]
egdytrixat-qphzti-tcvxcttgxcv-245[tcxgi]
htqtwkzq-wfintfhynaj-xhfajsljw-mzsy-jslnsjjwnsl-645[eynzi]
vrurcjah-pajmn-npp-mnyuxhvnwc-563[npach]
ejpanjwpekjwh-acc-klanwpekjo-576[jaekp]
kwvacumz-ozilm-kpwkwtibm-uizsmbqvo-876[mikwz]
hjgbwuladw-xdgowj-esfsywewfl-866[byzdm]
pbybeshy-wryylorna-npdhvfvgvba-351[stmxy]
qjopwxha-ywjzu-hkceopeyo-654[tysoa]
lhkhszqx-fqzcd-dff-vnqjrgno-417[fqdhn]
rgllk-otaoaxmfq-fdmuzuzs-768[vkqac]
ohmnuvfy-xsy-omyl-nymncha-214[hmtfs]
enzcntvat-cynfgvp-tenff-nanylfvf-455[cuimh]
sedikcuh-whqtu-sehheiylu-tou-bqrehqjeho-868[ydaux]
tyepcyletzylw-ojp-opalcexpye-145[wciks]
udpsdjlqj-hjj-frqwdlqphqw-309[gbpcz]
eqpuwogt-itcfg-lgnnadgcp-vtckpkpi-388[gpcti]
rkpqxyib-pzxsbkdbo-erkq-zrpqljbo-pbosfzb-133[bpkoq]
kdijqrbu-sxesebqju-tufqhjcudj-114[tdbva]
gsvvswmzi-wgezirkiv-lyrx-irkmriivmrk-412[twsrk]
ucynmlgxcb-qaytclecp-fslr-amlryglkclr-704[lcrya]
xst-wigvix-veffmx-wxsveki-100[ocvmr]
surmhfwloh-vfdyhqjhu-kxqw-frqwdlqphqw-829[hqwfd]
xmrrq-usfvq-esfsywewfl-528[alidm]
zhdsrqlchg-lqwhuqdwlrqdo-sodvwlf-judvv-ghsorbphqw-777[rtnmj]
egdytrixat-xcitgcpixdcpa-rwdrdapit-uxcpcrxcv-245[cdabn]
yrwxefpi-ikk-gywxsqiv-wivzmgi-152[iwgkv]
qcffcgwjs-foppwh-obozmgwg-558[zotsu]
veqtekmrk-gerhc-gsexmrk-hitpscqirx-568[nczdq]
gzefmnxq-pkq-pqbmdfyqzf-794[jxrmh]
eadalsjq-yjsvw-usfvq-ugslafy-ugflsafewfl-632[fsalu]
esyfwlau-usfvq-ugslafy-vwhdgqewfl-684[flsuw]
ktfitzbgz-fbebmtkr-zktwx-utldxm-wxlbzg-683[afwhg]
wihmogyl-aluxy-vohhs-uwkocmcncih-292[wzryd]
bkzrrhehdc-idkkxadzm-lzmzfdldms-677[oxwvn]
clxalrtyr-qwzhpc-lnbftdtetzy-249[zryvn]
rgllk-fab-eqodqf-vqxxknqmz-pqbxakyqzf-222[qfkxa]
xjinphzm-bmvyz-xviyt-mzxzdqdib-603[xnhfs]
htsxzrjw-lwfij-hmthtqfyj-wjfhvznxnynts-385[zreuy]
myvybpev-gokzyxsjon-oqq-nozvyiwoxd-692[iyzuj]
hcd-gsqfsh-pogysh-gvwddwbu-480[mysuk]
hcd-gsqfsh-foppwh-rsgwub-428[kvtfs]
frqvxphu-judgh-exqqb-uhvhdufk-621[wtgmn]
vhglnfxk-zktwx-vahvhetmx-vhgmtbgfxgm-345[hnamj]
tagzsrsjvgmk-usfvq-ugslafy-ugflsafewfl-892[yckbv]
joufsobujpobm-gmpxfs-vtfs-uftujoh-233[foujs]
zsxyfgqj-ojqqdgjfs-zxjw-yjxynsl-593[jqsxy]
bnknqetk-atmmx-qdzbpthrhshnm-131[ecnmt]
hmsdqmzshnmzk-dff-sqzhmhmf-859[dnxcz]
hqtyeqsjylu-tou-udwyduuhydw-348[uydhq]
ktiaaqnqml-kpwkwtibm-zmikycqaqbqwv-772[tlrsg]
nzydfxpc-rclop-mtzslklcozfd-mfyyj-nfdezxpc-dpcgtnp-951[cpdfz]
ckgvutofkj-hatte-gtgreyoy-644[tgeko]
iwcjapey-zua-paydjkhkcu-628[hntmg]
bnknqetk-okzrshb-fqzrr-trdq-sdrshmf-729[tuzoy]
qmpmxevc-kvehi-yrwxefpi-glsgspexi-wlmttmrk-828[hsyvf]
amjmpdsj-njyqrga-epyqq-qcptgacq-106[bhysd]
dwbcjkun-ljwmh-mnyuxhvnwc-641[wuyrz]
gspsvjyp-jpsaiv-hiwmkr-854[zthel]
gsrwyqiv-kvehi-gerhc-stivexmsrw-750[whgse]
xjgjmapg-wpiit-ozxcijgjbt-889[ytsop]
xgjougizobk-kmm-rghuxgzuxe-280[cwrty]
zovldbkfz-oxjmxdfkd-oxyyfq-ixyloxqlov-653[snkwb]
qczcftiz-qvcqczohs-gsfjwqsg-142[cqszf]
krxqjijamxdb-mhn-ldbcxvna-bnaerln-771[ravbt]
pybgmyargtc-bwc-bcqgel-860[bcgya]
wyvqljapsl-jovjvshal-shivyhavyf-773[vahjl]
pbafhzre-tenqr-onfxrg-bcrengvbaf-221[zyaro]
glrcplyrgmlyj-bwc-pcqcypaf-132[clpyg]
dpmpsgvm-dboez-dpbujoh-tfswjdft-545[bdmzf]
dkqjcbctfqwu-rncuvke-itcuu-cpcnauku-700[cuknq]
ajmrxjlcren-yujbcrl-pajbb-anbnjalq-459[yslvg]
oazegyqd-sdmpq-bxmefuo-sdmee-fqotzaxask-586[vfmnu]
ugdgjxmd-jsttal-ksdwk-632[hfjix]
aietsrmdih-gvcskirmg-tpewxmg-kveww-vigimzmrk-412[kfcim]
drxevkzt-jtrmvexvi-ylek-uvgcfpdvek-685[vekdr]
excdklvo-bkllsd-nozvyiwoxd-250[dlokv]
uwtojhynqj-hfsid-wjxjfwhm-281[fqsmx]
plolwdub-judgh-udeelw-uhfhlylqj-205[ludhe]
oqnidbshkd-dff-zmzkxrhr-729[cvlkx]
bknsykmdsfo-tovvilokx-bomosfsxq-328[boqly]
dpotvnfs-hsbef-qspkfdujmf-cvooz-tijqqjoh-961[zmnyi]
gspsvjyp-fyrrc-gsrxemrqirx-490[rsgpx]
gifavtkzcv-szfyrqriuflj-wcfnvi-uvmvcfgdvek-139[zadfj]
gsrwyqiv-kvehi-wgezirkiv-lyrx-wxsveki-490[alpzb]
ykhknbqh-ydkykhwpa-zalhkuiajp-862[khayp]
dmybmsuzs-yuxufmdk-sdmpq-bxmefuo-sdmee-fqotzaxask-586[nwikx]
nwzekwypera-bhksan-nayaerejc-940[xnmta]
wrs-vhfuhw-hjj-zrunvkrs-283[hrjsu]
ajyqqgdgcb-pyzzgr-amlryglkclr-782[lozts]
ohmnuvfy-jfumncw-alumm-womnigyl-mylpcwy-110[mqrgd]
foadouwbu-suu-obozmgwg-792[hgkuj]
wdjcvuvmyjpn-ytz-yzkgjthzio-109[jyztv]
ucynmlgxcb-pyzzgr-qfgnngle-210[iftry]
ymszqfuo-omzpk-oamfuzs-pqhqxabyqzf-872[qzfmo]
clotzlnetgp-ojp-opawzjxpye-769[pnhtz]
mhi-lxvkxm-yehpxk-ftgtzxfxgm-657[etajx]
surmhfwloh-fkrfrodwh-uhfhlylqj-699[rkslj]
iruzfrtkzmv-tyftfcrkv-kirzezex-841[emztq]
bdavqofuxq-nmewqf-ogefayqd-eqdhuoq-352[jpmyv]
bdavqofuxq-otaoaxmfq-xasuefuoe-326[aofqu]
gpsxdprixkt-tvv-ldgzhwde-219[dgptv]
pbeebfvir-rtt-bcrengvbaf-897[enlaq]
jchipqat-gpqqxi-bpgztixcv-375[cnqyt]
glrcplyrgmlyj-qaytclecp-fslr-pcqcypaf-574[clpyr]
pejji-oqq-vyqscdsmc-640[qcjsd]
houngfgxjuay-yigbktmkx-natz-xkykgxin-774[mszcw]
ltpedcxots-jchipqat-gpqqxi-bpcpvtbtci-219[isgfv]
gifavtkzcv-tyftfcrkv-drerxvdvek-659[vbdyz]
vjpwncrl-mhn-orwjwlrwp-641[wrjln]
vjpwncrl-ouxfna-bcxajpn-511[ydzfw]
rzvkjiduzy-xviyt-xjvodib-adivixdib-187[idvxb]
tinnm-suu-twbobqwbu-272[datjf]
apuut-xviyt-vxlpdndodji-941[zrtso]
jxdkbqfz-zixppfcfba-mixpqfz-doxpp-jxohbqfkd-705[fpxbd]
zilqwikbqdm-lgm-kwvbiqvumvb-876[bqpme]
jyddc-wgezirkiv-lyrx-wxsveki-256[sjntv]
ahngzyzqcntr-qzaahs-zbpthrhshnm-963[fzvai]
ksodcbwnsr-qfmcusbwq-suu-qighcasf-gsfjwqs-350[wyezk]
atyzghrk-igtje-iugzotm-jkyomt-462[ksuli]
dwbcjkun-ajmrxjlcren-yujbcrl-pajbb-nwprwnnarwp-563[tjsqg]
aoubshwq-dzoghwq-ufogg-aofyshwbu-896[hwcmz]
apwmeclga-npmhcargjc-njyqrga-epyqq-rpyglgle-340[dgtsc]
apwmeclga-aylbw-amyrgle-dglylagle-210[iumzy]
ydjuhdqjyedqb-rkddo-sedjqydcudj-738[ycbmx]
iuxxuyobk-xgjougizobk-pkrrehkgt-sgtgmksktz-644[pzsmw]
bnmrtldq-fqzcd-bgnbnkzsd-vnqjrgno-521[nbdqg]
wfruflnsl-gzssd-wjhjnansl-177[wtmsg]
yhwooebeaz-ywjzu-klanwpekjo-680[eowaj]
pynffvsvrq-cynfgvp-tenff-ernpdhvfvgvba-663[vbduy]
zilqwikbqdm-ntwemz-uizsmbqvo-356[yhenq]
jvsvymbs-zjhclunly-obua-jvuahputlua-721[uajlv]
fhezusjybu-rqiauj-tufbeocudj-400[ecamb]
ftzgxmbv-wrx-xgzbgxxkbgz-293[xgbzf]
chnylhuncihuf-xsy-xypyfijgyhn-578[jigcy]
vhkkhlbox-pxtihgbsxw-cxeeruxtg-wxlbzg-111[hsuty]
foadouwbu-tzcksf-gozsg-246[ofgsu]
xzwrmkbqtm-moo-nqvivkqvo-434[moqvk]
gvaaz-cvooz-dpoubjonfou-415[mcnzb]
pbafhzre-tenqr-enoovg-grpuabybtl-169[bktjl]
uwtojhynqj-gzssd-ywfnsnsl-723[phguv]
dlhwvupglk-zjhclunly-obua-klwhyatlua-227[luahk]
vhkkhlbox-vhehkyne-vahvhetmx-ybgtgvbgz-215[hvbeg]
qlm-pbzobq-gbiivybxk-lmboxqflkp-809[blqik]
forwcoqhwjs-qvcqczohs-ghcfous-792[mtuqn]
eqpuwogt-itcfg-dwppa-fgrnqaogpv-570[gpafo]
lxuxaodu-bljenwpna-qdwc-jwjuhbrb-121[rbqfd]
ykhknbqh-xqjju-oanreyao-680[ahjkn]
ugfkmewj-yjsvw-hdsklau-yjskk-kzahhafy-918[kahjs]
gbc-frperg-fpniratre-uhag-fnyrf-897[dskta]
myxcewob-qbkno-lexxi-wkxkqowoxd-770[spdoc]
cqwdujys-fbqijys-whqii-huiuqhsx-998[uhebs]
ckgvutofkj-igtje-iugzotm-rghuxgzuxe-774[gutei]
excdklvo-lexxi-psxkxmsxq-302[ypsmx]
mbiyqoxsm-dyz-combod-mkxni-mykdsxq-zebmrkcsxq-692[fnhpz]
zlkprjbo-doxab-gbiivybxk-xkxivpfp-809[ydtxn]
wdjcvuvmyjpn-ezggtwzvi-hvmfzodib-603[vzdgi]
njmjubsz-hsbef-fhh-bobmztjt-649[mxkjw]
wsvsdkbi-qbkno-oqq-ecob-docdsxq-796[rglok]
htsxzrjw-lwfij-gfxpjy-fsfqdxnx-307[uyteb]
wpuvcdng-ejqeqncvg-yqtmujqr-882[svamn]
tagzsrsjvgmk-hdsklau-yjskk-ugflsafewfl-606[tysrn]
kwtwznct-akidmvomz-pcvb-zmamizkp-200[skpom]
dpmpsgvm-dboez-dpbujoh-fohjoffsjoh-311[fknst]
rnqnyfwd-lwfij-hmthtqfyj-xytwflj-567[gzkol]
zntargvp-pnaql-hfre-grfgvat-923[yijbm]
dzczkrip-xiruv-treup-tfrkzex-drerxvdvek-347[vrmsu]
ajyqqgdgcb-afmamjyrc-sqcp-rcqrgle-522[cqagr]
pelbtravp-ohaal-erprvivat-715[jnbmz]
irdgrxzex-sleep-ivrthlzjzkzfe-113[bmsnw]
eqpuwogt-itcfg-tcddkv-fgxgnqrogpv-804[gtcdf]
cvabijtm-moo-ivitgaqa-226[darfu]
ytu-xjhwjy-xhfajsljw-mzsy-zxjw-yjxynsl-281[wzjeb]
fkqbokxqflkxi-yxphbq-obxznrfpfqflk-809[dcasb]
gokzyxsjon-sxdobxkdsyxkv-mkxni-ecob-docdsxq-276[zypso]
ibghopzs-suu-kcfygvcd-402[cgsub]
tfiifjzmv-srjbvk-uvjzxe-581[sovtj]
gntmfefwitzx-gfxpjy-xmnuunsl-619[fnxgm]
lgh-kwujwl-bwddqtwsf-vwhsjlewfl-788[tlejf]
hjgbwuladw-wyy-ghwjslagfk-164[wgahj]
nzwzcqfw-ojp-qtylyntyr-431[ynqtw]
sbejpbdujwf-sbccju-vtfs-uftujoh-909[kujit]
vhkkhlbox-wrx-ftkdxmbgz-241[uwzex]
lahxpnwrl-bljenwpna-qdwc-cajrwrwp-381[yjzno]
lugjuacha-jfumncw-alumm-jolwbumcha-838[uamcj]
gvcskirmg-glsgspexi-jmrergmrk-828[smeyi]
thnulapj-ihzrla-thyrlapun-955[ahlnp]
sno-rdbqds-bzmcx-btrsnldq-rdquhbd-937[dbqrs]
vdzonmhydc-eknvdq-dmfhmddqhmf-781[dmhfn]
iehepwnu-cnwza-xqjju-ykjpwejiajp-368[jepwa]
dfcxsqhwzs-dzoghwq-ufogg-cdsfohwcbg-974[gcdfh]
sbqiiyvyut-tou-jhqydydw-608[okbzs]
htsxzrjw-lwfij-gzssd-uzwhmfxnsl-801[nmtjq]
hvbizodx-rzvkjiduzy-xviyt-yzqzgjkhzio-213[zivyd]
ajmrxjlcren-ljwmh-lxjcrwp-bqryyrwp-745[kheat]
vkppo-shoewudys-tou-udwyduuhydw-556[udowy]
dpotvnfs-hsbef-dmbttjgjfe-gmpxfs-nbslfujoh-363[qapli]
glrcplyrgmlyj-djmucp-qrmpyec-158[clmpr]
emixwvqhml-xtiabqk-oziaa-wxmzibqwva-642[rkpba]
qczcftiz-dzoghwq-ufogg-aofyshwbu-298[lmcuy]
cvabijtm-zilqwikbqdm-akidmvomz-pcvb-nqvivkqvo-746[ynxzo]
pkl-oaynap-acc-wjwhuoeo-134[jxlai]
xjmmjndqz-kgvnodx-bmvnn-rjmfncjk-291[njmdk]
ejpanjwpekjwh-nwxxep-nayaerejc-550[lisvd]
htwwtxnaj-htsxzrjw-lwfij-hfsid-htfynsl-wjfhvznxnynts-541[hntwf]
mbiyqoxsm-mkxni-mykdsxq-crszzsxq-770[zhowm]
rmn-qcapcr-ucynmlgxcb-cee-pcqcypaf-886[cpaem]
rtqlgevkng-ejqeqncvg-fgxgnqrogpv-466[zktns]
fydelmwp-mfyyj-nfdezxpc-dpcgtnp-769[anfej]
yuxufmdk-sdmpq-otaoaxmfq-pqbxakyqzf-742[ohxti]
vxupkizork-igtje-xkgiwaoyozout-592[bmwjf]
veqtekmrk-tvsnigxmpi-gerhc-gsexmrk-gywxsqiv-wivzmgi-802[dglps]
nsyjwsfyntsfq-uqfxynh-lwfxx-ijuqtdrjsy-931[ymnhu]
gifavtkzcv-avccpsvre-fgvirkzfej-841[ypigz]
krxqjijamxdb-kdwwh-mnyjacvnwc-641[krnma]
dszphfojd-ezf-sftfbsdi-805[fdszb]
xmrrq-tmffq-lwuzfgdgyq-372[fqgmr]
tagzsrsjvgmk-xdgowj-vwhsjlewfl-788[gjswl]
lsyrkjkbnyec-mkxni-nofovyzwoxd-614[knoyx]
dwbcjkun-mhn-bjunb-173[mykra]
vhehkyne-vtgwr-nlxk-mxlmbgz-319[eghkl]
bkzrrhehdc-bnqqnrhud-bzmcx-bnzshmf-otqbgzrhmf-677[xaszn]
oxmeeuruqp-bxmefuo-sdmee-abqdmfuaze-248[udtec]
jlidywncfy-mwupyhayl-bohn-uhufsmcm-500[yhmuc]
xjmmjndqz-zbb-mzvxlpdndodji-239[djmzb]
yuxufmdk-sdmpq-omzpk-qzsuzqqduzs-534[ofrpg]
tfejldvi-xiruv-vxx-uvgrikdvek-659[cnesm]
yaxsnlcrun-ajkkrc-anbnjalq-979[nmivs]
tvsnigxmpi-ikk-wivzmgiw-880[agunv]
mrxivrexmsrep-tpewxmg-kveww-viwievgl-698[evwim]
nglmtuex-yehpxk-labiibgz-241[begil]
zuv-ykixkz-ixeumktoi-igtje-iugzotm-aykx-zkyzotm-670[pjybl]
forwcoqhwjs-dzoghwq-ufogg-difqvogwbu-272[xkwoz]
ajyqqgdgcb-qaytclecp-fslr-bcqgel-886[mkvsi]
myxcewob-qbkno-mkxni-mykdsxq-wkbuodsxq-770[zmijb]
uwtojhynqj-kqtbjw-yjhmstqtld-333[jtqhw]
wsvsdkbi-qbkno-lkcuod-dbksxsxq-406[biaoe]
gpbepvxcv-rpcsn-rdpixcv-advxhixrh-895[dcwgp]
muqfedyput-isqludwuh-xkdj-mehaixef-712[betdq]
ckgvutofkj-inuiurgzk-xkgiwaoyozout-956[sazyo]
wfruflnsl-uqfxynh-lwfxx-btwpxmtu-541[fxluw]
qfmcusbwq-rms-igsf-hsghwbu-246[sbfgh]
ynukcajey-nwxxep-qoan-paopejc-602[htmbv]
ujqgywfau-uzgugdslw-jwkwsjuz-138[newms]
yflexwxoalrp-zxkav-cfkxkzfkd-705[ctnsy]
vjpwncrl-lqxlxujcn-mnyuxhvnwc-953[nawmz]
willimcpy-wuhxs-lyuwkocmcncih-786[cilwh]
mtzslklcozfd-clmmte-cpnptgtyr-119[tjkgv]
xlrypetn-awldetn-rcldd-cplnbftdtetzy-795[tdlen]
vkppo-rqiauj-huqsgkyiyjyed-452[yijkp]
vxupkizork-lruckx-jkbkruvsktz-124[eumyz]
diozmivodjivg-agjrzm-nzmqdxzn-915[otpfl]
owshgfarwv-hdsklau-yjskk-klgjsyw-918[qcjim]
zuv-ykixkz-igtje-iugzotm-zkinturume-202[plvqf]
zlilocri-oxyyfq-bkdfkbbofkd-835[bswmn]
ziuxioqvo-lgm-amzdqkma-798[maioq]
xqvwdeoh-sodvwlf-judvv-ghyhorsphqw-517[hvdow]
ovbunmneqbhf-enqvbnpgvir-onfxrg-qrfvta-507[nvbfq]
gbc-frperg-pnaql-genvavat-351[pmzkq]
eadalsjq-yjsvw-jsttal-suimakalagf-580[zjghy]
rdadguja-rpcsn-rdpixcv-apqdgpidgn-245[dpagr]
tbxmlkfwba-pzxsbkdbo-erkq-abpfdk-523[vifrq]
ocipgvke-uecxgpigt-jwpv-ugtxkegu-544[abfsh]
ovbunmneqbhf-zvyvgnel-tenqr-wryylorna-ybtvfgvpf-481[hxymg]
pinovwgz-xjinphzm-bmvyz-agjrzm-ozxcijgjbt-681[cqlnu]
tinnm-qobrm-ghcfous-220[hyczt]
iuruxlar-yigbktmkx-natz-ykxboiky-748[kixya]
bkzrrhehdc-bzmcx-bnzshmf-cdrhfm-209[hbcmr]
gpsxdprixkt-tvv-uxcpcrxcv-973[xcpvr]
forwcoqhwjs-rms-hfowbwbu-974[stzrm]
zovldbkfz-fkqbokxqflkxi-mixpqfz-doxpp-cfkxkzfkd-705[tsmfo]
vetllbybxw-lvtoxgzxk-angm-ftgtzxfxgm-371[sbemy]
hwbba-ejqeqncvg-tgugctej-232[iyrqv]
vqr-ugetgv-lgnnadgcp-wugt-vguvkpi-596[gvunp]
xgvnndadzy-wpiit-yzndbi-343[rawyd]
jxdkbqfz-oxyyfq-qbzeklildv-107[qbdfk]
wlsiayhcw-luvvcn-mufym-656[jbvne]
surmhfwloh-fdqgb-ghvljq-621[ymnve]
mvkccspson-bkllsd-vklybkdybi-432[yscux]
dszphfojd-sbccju-dvtupnfs-tfswjdf-129[itbfs]
lsyrkjkbnyec-lexxi-crszzsxq-978[sxcek]
qlm-pbzobq-mixpqfz-doxpp-zlkqxfkjbkq-211[satyb]
bknsykmdsfo-nio-kmaescsdsyx-744[tspif]
bpvctixr-rpcsn-rjhidbtg-htgkxrt-713[rtbcg]
sebehvkb-rqiauj-udwyduuhydw-140[udbeh]
zhdsrqlchg-fdqgb-hqjlqhhulqj-387[zptrs]
qxdwpopgsdjh-rpcsn-sthxvc-635[nbixj]
pualyuhapvuhs-msvdly-klzpnu-721[ulpah]
sbqiiyvyut-shoewudys-isqludwuh-xkdj-jhqydydw-894[dysuh]
wsvsdkbi-qbkno-lexxi-dbksxsxq-614[onzwh]
ydjuhdqjyedqb-rqiauj-efuhqjyedi-894[ocdpe]
kwzzwaqdm-ntwemz-wxmzibqwva-434[nwzml]
qspkfdujmf-fhh-nbobhfnfou-571[zpyau]
bxaxipgn-vgpst-tvv-detgpixdch-583[xwiac]
qfmcusbwq-dfcxsqhwzs-xszzmpsob-fsqswjwbu-402[lstrx]
dpmpsgvm-dboez-sfdfjwjoh-337[dfjmo]
dzoghwq-ufogg-fsgsofqv-636[gfoqs]
nzwzcqfw-dnlgpyrpc-sfye-qtylyntyr-509[milhd]
xgsvgmotm-pkrrehkgt-vaxingyotm-176[jubcm]
xgsvgmotm-jek-cuxqynuv-644[soxwn]
cxy-bnlanc-lahxpnwrl-kdwwh-fxatbqxy-485[zamhj]
irgyyolokj-inuiurgzk-sgtgmksktz-982[vzkrq]
xgvnndadzy-xcjxjgvoz-xjiovdihzio-733[ozhyu]
gvcskirmg-nippcfier-xiglrspskc-334[bastq]
zlilocri-gbiivybxk-obxznrfpfqflk-367[ntyda]
pyknyegle-pyzzgr-pcqcypaf-886[nxvzy]
zhdsrqlchg-gbh-frqwdlqphqw-361[nqzts]
kyelcrga-cee-yaosgqgrgml-808[izdqr]
hplazytkpo-prr-cpnptgtyr-379[prtya]
";
            var d04 = new Day04(input);
            Console.WriteLine($"Day 04");
            Console.WriteLine($"------");
            Console.WriteLine($"Of the real rooms from the input list, the sum of their sector IDs is {d04.SectorIdSum}");
            foreach (var r in d04.Rooms) {
              if (r.Name == "northpole object storage") {
                Console.WriteLine($"The sector ID of the room where North Pole objects are stored is {r.SectorId}");
              }
            }
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 03
            // /////////////////////////////////////////////////
        
            input = @"  775  785  361
  622  375  125
  297  839  375
  245   38  891
  503  463  849
  731  482  759
   29  734  734
  245  771  269
  261  315  904
  669   96  581
  570  745  156
  124  678  684
  472  360   73
  174  251  926
  406  408  976
  413  238  571
  375  554   22
  211  379  590
  271  821  847
  696  253  116
  513  972  959
  539  557  752
  168  362  550
  690  236  284
  434   91  818
  859  393  779
  620  313   56
  188  983  783
  799  900  573
  932  359  565
  357  670   69
  525   71   52
  640  654   43
  695  781  907
  676  680  938
   63  507  570
  985  492  587
  984   34  333
   25  489  399
  470  158   43
  715  491  617
  508  412  607
  365  446  743
  504  189  378
  225  424  517
  473   45  649
  847  927  424
  455  889  697
   64  230  846
  579  368  881
  639  536   74
  433  803  943
   14  629  963
  432  481  136
  781  625  323
  836  215  201
  620  614  366
  801  679  673
  745  376  326
  891  957  751
   64  430  347
  784  534  237
  740  485  470
  570  894  790
  905  979   90
  571  526  716
  810  602  259
   20   41  648
  816  566  848
  891  883  616
  801  797  341
   99  119  584
  175   40  994
    8  234  831
  184  254  958
  625  999  945
  326  385  266
  475  644  785
  345  769  650
  427  410  680
  689  887   40
  380  109  842
  342  640  785
  164  546  554
  843  871  419
  873  687   74
   84  192  465
  186  777   83
  180  130  726
  315  860  652
   88  273  735
  859  684  791
  806  655  299
  763  409  636
  310  532  897
  891  163  855
  631  200  986
  104  559  294
  555  679  989
  770  437  935
  997  189  711
  830  300  983
  566  325  793
    7  694  911
  574  490  138
  596  230  973
  855  377  552
  969  150  518
  453  653  525
  753  556   47
  858  509  551
  103  545  325
  660  215  284
  566  509  591
  647   97  650
  993  597  775
  970  566  802
  242  922  349
  693  932  502
  872  267  657
  526   87  944
  395   85  188
  134  129  901
   56  244  785
    1  733  300
   55  698  552
  372  933  480
  548  459  792
  631  653  983
  443  320   23
  555  117  715
  665  268  704
  804  899  736
  654  823   13
  441  250  736
  229  324  580
   41  389  857
  215  103  753
  933  311  835
  955  234  744
  113  141  315
  790  130  235
  464  464  129
  328  386  315
  787  735  301
  839  744  299
   77  119   23
  407  321  190
  968  962  904
  653  752  732
  962  145  723
  175  452  717
  868  474  195
   10  273  943
  308  388  626
  296  133  647
  851  474  336
  839  777  975
  514  651  867
  949  947  886
  802   92  113
  167  938  941
  840  627  166
  825   72  754
  166  661  677
  759   71  279
  705   70  113
  849    4  295
  563  679  588
  343   76  636
  842  669   45
  892  597  431
   26  864  580
  889  509  641
  696  267  506
  608  778  297
  293  867  667
  662  469   97
  243  184  809
  785  434  715
  691  568  759
  599    4  164
  444  566  816
  486  145  595
  787   41  538
  953  151  842
  861  877  759
  228  972  678
  846  114  915
  253   41  621
   59  989  405
  222  948  665
  478  631  364
  524  717  175
  752   94  474
   47  421  419
  113  510  343
   99  733  667
  787  651  708
  703  557  486
  489  637  702
  510  287  529
  483  308  545
  454  177   87
  433  735  242
  638  734  172
  208  702  285
  999  157  251
  776   76  341
  689  164  553
  477  938  456
   45  848  863
  466  255  644
  578  396   93
  471  419  368
  411   27  320
  317  291  732
  303   42  605
  597  313  473
   70  419  120
  101  440  745
   35  176  656
  236  329  198
   74  296   40
  272   78  233
  864  404  510
   37  368  531
  828   35   50
  191  272  396
  238  548  387
  129  527   13
  464  600  194
  385   42  341
   81  596  432
  589  663  943
  256  704  723
  671  152  505
  873  532  364
  758  755  202
  378  621  563
  735  463  555
  806  910  409
  809  897  276
  546  755  608
  609  852   79
  279  133  527
  106  696  980
   63  981  360
   90  440  832
  127  860  495
  714  395  480
  815  485   59
  792   91  507
  249  524  138
  567  452  486
  923  544  768
  913  253  767
  456  582  293
  706  507  577
  187  619  644
  569  978  602
   88  886  291
  448  712  211
  517  815  258
  743  397  816
  977  793  795
  847  905  668
  690  869  162
  426  541  257
  637  586  272
   82  950  821
  785  936  350
  812   31  490
  318  253  159
  515  688  479
  423  855  407
  931  830  651
  496  241   28
  491  924  624
  864  966  133
  171  438  712
  736  867  734
  551  548  267
  288  455  474
  557  622  273
  494   74  507
  541  628  390
  288  583  310
  411   63  353
  487  527  295
  520  567  536
  739  816  848
  349  681  269
  898  902  676
  647  759  892
  573  512   75
  186  252  895
  804  320  772
  730  934  107
  198  651  774
  625  535  985
  568  499  235
  159   42  837
  854  617  695
   34  299  670
  823  733   41
  830  615  789
  825  652  562
  697  105  504
  114  103  540
   18  141  106
   94  121  479
  859  774  177
  464  873  208
  790  125  305
  982  586  811
  521  386  478
  916  329  620
  764   91  351
  526  684  103
  314  749  283
  510  226  378
  160  269  278
  638  368  120
  616  540  475
  863  637   89
  744  172  445
  856  391  269
  768  276  634
  940  610  820
  289  254  649
  254  364   98
  304  613  620
  164  652  257
  890   74  483
  813  640  710
  884   99  735
  707  881  380
  954  983  971
  487  911  275
  256  920   43
  384  772  313
  863  120  903
  703  821   82
  765  731  957
   55  935  516
  162  785  801
  140  161  927
  460  139   84
  926  139  965
  764    3  976
  765  487   42
  377  835  277
  897  734  256
  345  320   55
  515  755  504
  615  623  562
  412  280    6
  382  392  468
  365  625  461
  542  406  610
  360  200  801
  562  221  627
  556  557  141
  372  231  212
  523  457  272
   80  701  676
  940   59  871
  906  695  987
  715  922  573
  618  446  552
  196  849   62
  772  867  608
  735  377  418
  676  607  236
   25  447  830
  187  270  738
  214  175  990
  438  790  816
  456  396  534
  220  628  356
  384  935  215
  377  593  802
  566  651  650
  648  529  999
  128  884  472
  688  951  661
  312  722  722
   48  526  696
  266  347  903
  698   21  354
  933  404  570
  303  417  685
   46  562  897
  566  931   14
  539  747  911
  374  623  743
  868  353  513
  927  903  481
  207  765  560
  351  956  215
  540  945  512
  362  322  651
  820  555  190
  548  301  467
  405  931  842
  598  347  150
  276  971  814
  450  480  361
  577  538  493
  139  104  181
  716  233  697
  494  647  287
  511  782  575
  809  728  107
  895  167   85
  741  746  141
   23  115   83
  173  147  549
  191  208  581
  313  356  284
  357  393  123
   60  322  363
  830   87  661
  403  711  713
  433  651  101
  783  738  792
  574  821  764
  705  214  263
  256  243  334
  341  152  444
  520  140  131
  975  461  313
  319  441  161
  791   47  309
  228  973  235
  583  305  398
  389  876  277
  551  974  351
  822  786  876
  364  347  874
  523  130  173
  806   90  462
  304  146  402
  748  760  239
  164  345  704
  833  817  628
  239  739  640
  284  296  234
  127  711  415
  435  590  402
  480  250  914
  282  379  914
  547  845  267
  922  795  324
  600  500  447
  342  464   53
  404  341  143
  641  129   90
  375  730  138
  263   32  124
  450  749  251
  588  697   89
  688  431  603
  156  614  617
  604  259  349
  475  282   45
  572  197  308
  743  749  686
  770  811  907
  117  543  845
   41  179  766
  147  555  742
  130  410  169
  476   62  627
  652  879  240
  678  852  508
  953  795  413
  699  597  444
  324  577  846
  919   79  727
  908  719  125
  128  776  714
  299  256  118
  513  222  115
  624   75  181
    1  605  162
   55  106  230
   58  672  286
  639  558  549
  150  662  435
  662  695  222
  461  173  344
  428  354  647
   56  405  653
  699  631  995
  967  608  269
  365  853  794
  768  606  943
  413  601  128
  362  427  919
  735  448  566
  276  354  377
  604  657  544
  913  192  592
  811  762   62
  120  720  606
  618  232  392
   85   19  764
  603  241  541
  993  997  840
  818  894  266
  247  305  682
  280  964  511
  559  967  455
  531   38  674
  878  731  684
  783  156  390
  617  742  604
  370  770  896
  592  667  353
  222  921  736
  741  508  285
  759  395  156
   37  128  254
  209  631  716
  237  423  613
   65  856  439
  942  526  288
  862  811  341
  753  840   59
  369   67  907
  817  947  802
  768  945  137
  356  557  207
  716    9  205
  361  558    1
  310  889  719
   97  128  887
  361  776  873
   86  181  892
  284  865  808
  218  859  279
  299  649  624
  542  583  624
  617   66   48
  921  459   75
  921  672  759
  800  345  814
  572  975  685
  720  980  867
  522  135  267
  139  376   86
  362  399  585
  330  206  511
  419  194  679
  293  374    3
  560  272  676
  224  926  717
  685  927  347
  555  786  943
  591  776  538
  326  835  471
  635   67  464
  276  916  913
  304  965    2
   50  110  912
  893  200  307
  445  248  596
  725  128  681
  279  602  888
    7  204  766
  284  429  191
  264  503  351
  531  335  140
  381  220  292
  518  905  824
  416  477  600
  405  663  511
  531   92  321
  824  131  534
  409  113  431
   12  192  485
  864  557  391
  858  390  756
   28  465  231
  188  216  825
  177  316  910
  766   41  329
  202  105  219
  787  125  542
  639  108    5
  639   10  525
   17  105  532
  586  498  918
  630  389   19
  317  361  903
  185  575  708
  679  532  355
  851  367  844
  775   68  120
  644   45  194
  802   44  242
  852  214  601
  595  525  281
  258  450  415
  534  121  561
  117   33  620
  576  147  318
  217  953  365
  863  686  803
  751  694  680
  502  669  546
  385  204  399
  740  760  650
  105  567  227
  526  574  378
  496  858  216
  248  475   19
  790  358  887
  556  713  866
  348  334  937
  364  364   88
  396   58  915
  871  418  645
  438  507  449
  967  924  960
  435  153   47
  831  861  835
  787  958  832
  376  231  602
  487  528  782
  485  532  607
  820   96  256
  856  177  549
  302  240  751
  146  412  332
  268  715  463
  309  584  399
  939  548  465
  966  854  412
  517  385  574
  425  809  919
   88  796  924
  468  317  287
  195  131  961
   10  485  229
  190  374  827
  573  178  842
  575  255  358
  220  359  713
  401  853  206
  736  904  667
  450  209  798
  865   42  300
  806  373  182
  383  403  258
  397   51  691
  492  146  568
  814  179  584
  545  851  182
  606  135  208
  135  934  183
  733  365  561
  215   97  642
  617  418  209
  641  297  106
  400  876  246
  399  665  156
  424   20  222
  954  860  194
  930  875   34
  883  469  376
  111  576  753
  995  515  461
  535  380  786
  117  578  780
  646  803  965
  243  951  886
  563  935  879
  520   91  879
  390  332  402
  955  471  221
  810  398  527
  312  876  131
  256  371  527
  293  945  501
  724  900  650
  798  526  908
  199  510  377
  285  338  780
  729  157  584
  866  259  438
   91  680  717
  982  618  786
  918  255  178
   66  257  416
  288  223   81
  237  405  404
  597  762  518
  671  661   39
  976  431  502
  524  337  919
  524  194  343
   23  167  623
  882  993  129
  741  572  465
  694  830  394
  353  846  895
  312  254  903
   52  614  101
  300  513  706
  976  310  698
  929  736   22
  732  248  113
  816  471  405
  230  466  355
  749  854  492
  956  286  554
  833  928  239
  334  883  528
  782  968  977
  715  608  898
  264  576  100
  530  705  344
  779  189  245
  560  692  658
  550  325  931
   22  757  277
  860  962  567
  695  542  611
  227  936  116
  812  696  604
  889  520  282
  512  180  350
  735  582  392
  511  400  667
  754  871  309
  899  133  582
  986   66  309
  186  183  367
  543  242  522
  132  255  887
  538  225  934
   57  276  438
  452  396  382
  501  608  195
  292  741  619
   69  671  801
  331  731  279
  485  350  380
   81  926  182
  513  834  298
  165  801  799
  204  426  521
  245  650  330
  716  716  155
  693  699  658
  305   69  710
  661  744  698
  599  327  957
  577  593  903
  924  117  176
  949  808  323
  267  710  257
   91  683  927
  404  262  918
  347  716  109
  155  266  483
  142  676  512
  216  501  103
  923  110  424
  856  329  617
  229  332  231
  466  803  573
  498  388  827
   38  788  587
  770  367  435
  736  584  445
   93  569  834
   65  948  479
  172  630  581
  239  369  396
  820  270  656
   32  515  348
  803  324  969
   70  188  635
  219  766  279
  166  736  640
  257  604  851
  555  616  822
  589  345  165
  166  196   64
  909  185  700
  870  119  693
   20  565  737
  680  198  244
  700  486  825
  194  812   67
  236  756  407
   64  905  344
   92  755  905
  748  349  681
  707  781  811
  505   50  456
  471  889  672
   35  891  334
  899  411  164
  663  459  232
  539  446  322
   57  785  718
  273  421  308
  308  744  501
   45  819  416
  936  258  466
  980  825  841
  100   33  345
  898  904  750
  920  903  453
  947    9  765
  580  979  375
  753  977  844
  402  174  156
  573  827  782
  975  663  644
  179  358  353
   55  777  834
  221  871  631
  120  714  199
  663  369  217
  599  713  135
   11  472  765
  803  445  746
  797   30  284
  259  776  677
  598  707  675
  484  339    3
  298  750  162
  119  820  168
  180   69    9
  433  332  676
  142  164  343
  435  233  414
  153  977  263
  532   54  244
  600  999   25
  394  756  311
  354  196  703
  666  858  760
  227  312  525
  389  419  436
  218  311  744
  318  531  245
  324  939  509
  183  997  543
  944  598   70
  790  486  828
  710  745  880
  546  368  219
  316  668   29
  398  360  218
  702  453  987
  774  462  373
  722  829  947
  541  732   44
  310  494  582
  239  596  548
  579  810  907
  490  169   62
  926  883  915
  281  414  595
  845  412  609
  632  106  618
  112  404  492
  864  460  314
  842   93  436
  412  805  874
  353  686  465
  240  393  800
  788  654  346
  666   78  185
  418  608  404
  658  537  960
  794  449  680
  711  324  489
   59  525  330
  323  259  544
  359  745  542
  877  701  403
  119  897  533
  977  392  227
  528  340  194
  398  180  283
  538  301  123
  775  263  195
   53  385  630
  749  253  686
  533   30  624
  678  187  590
  937  218   50
  205  466  918
  796  672   47
  818  203  963
  461  953  881
  739  457  696
  661  711  220
  624  121  663
  908  173  644
  602  185   70
  168  957  159
  283  341  934
  196  845  939
  494  354  543
  796  422   87
  430  762  478
  526  762  859
  535  600  926
   28  555  651
  170  748  379
  117  745   33
   52    1  351
  946  796  446
  148  844  920
  950  131  740
  392  490  118
  286  465  667
  202  101  662
  326  629  556
  773  661  219
  540  683  613
  406  314  525
  154  947  451
  401  661  186
  574  690  796
  558  730  855
  153  244  156
  618   37   10
  856  991  363
  820  959  370
  644  700  800
  421  469  908
  422  233  288
  416  281  707
  370  430  487
  284  525  916
  535  713  354
  210  576  524
  432  930  215
  712  374  612
  686  508  102
   40  141  616
  979  525  663
  838  696  326
  472  261  357
  321  910  663
  228  153  536
  223  940  896
  137   39  506
  139  706  187
    4  666  483
  944  856  119
  720  602   93
  410  260   85
  601  647  520
  162  474  317
  599  742  313
  242  886  381
  250   78  353
  109  916  117
  597  926  673
  318  114  309
  892  819  424
  491  682   85
  765  657  682
  558   60  721
  990  634  160
  640  461  410
  430  839  535
   42  961  686
  752  251  690
  747  931    3
  439  930   85
   44  628  953
  465  961  874
  313  447  913
  249  600  859
  359  896  472
  698  187  657
   57  957  805
  721  977  239
  782   93   96
  860  159  250
  368  142  218
  565  157   46
  622  403  383
   63  546  382
   63  774  308
  446  495  475
  467  831  310
  448   77  798
  930  281  189
  767  289  644
  514  765  524
  330  827  992
  340  284  964
  600   97  785
  418  432  755
  983  442   58
  872  435  725
  107  344  315
  917  682  547
   24  613  561
  665  448  238
  680  872  737
  108  180  449
  220  545  583
  268  676  863
  796  791    2
  694  992   39
  788  767   41
  235  572  377
  975  864  883
  953  448  608
  909  888  452
   93  850  414
  852   48   49
  136  558  842
  300  428  776
  427  814   64
  223   45  283
  100  562  659
  290  519  828
  678  786  346
  371  711  934
  686  276  826
  808  208  669
  832  198    6
  317   11  675
  504  182  448
  162  745  642
  623  791  687
  408  947  693
  247  267  641
  328  693  758
  773  411  149
   66    2  589
  786  407  527
   81  760  803
  946  696  552
  878  698  994
  190  203  649
  548  713  634
  657  724  676
  195  397  887
  175  346  118
  356  264  981
  191  919  468
  490  470  570
  583  740  151
  340  773  889
  176  446  314
  206  384  935
  172  996  620
  362  842  497
  208  786  731
  207  395  750
  368  819   87
  524  524  702
  609  761  554
  753  975  290
  559  932  731
  584  203  140
  477  100  982
  784  162  876
  371  209   67
  236  754  108
  439  633  163
  734  717  626
  808  216  639
  133  521   94
  180  813  208
  136  770  844
   57  867  871
  700  900  740
   96   75  662
  628  893  284
  843  851  196
  546  427  607
  797  471  664
  180  363  117
  961  775   95
  846  969  210
  535  269  666
  216  585  490
  736  521  335
  489  493  602
  627  574  723
  857  217  629
  385  808  433
  615  115  361
  687  705  455
  898  390  177
  737  393  476
  355  727  371
  533  526   69
  615  467  157
  614  683  202
  876  892  581
  949  165  357
   86  766  432
  233   47  702
  448  407  821
  227  364  424
  158  372  933
  966  405  365
  913  512  813
  585  698  482
  720  171  716
  172  868  740
   96  489   33
  531  882  552
  618  949  523
  425  860  424
  909  676  116
  806  770  430
  836  868  355
  640  561  523
  858  353  411
  400  149  612
  872  364  491
  940  469  870
  127  256   47
  561  306  322
  626  147  276
   13  547  289
  218  561  705
  234   16  842
  301  663  261
   81  415  368
  301  945  593
  232  855  760
  522  649  929
  401  847  376
  764  542  452
  774  536  929
   10  935  499
  710  262   94
   72  475  524
  722  618  481
  515  135  637
  962  115  303
  665   88  416
  544  303  735
  828  488  680
  827  575  354
   44  999  437
  232  985  128
  226   36  346
  310  325  307
  473  809  315
  184  487   91
  778  310  926
  749  260  988
  869  216  878
  663  790  458
  914  237  476
  258  935  201
  956  796  313
  888  105  282
  160  874   42
  715  524  451
  477  604  886
  596  111  554
  524  510  388
  778  878  320
  894  453  574
  210  808  633
  340   77  956
  159  872  426
    4  756  333
  528  697  677
  530  474  442
   75  427  536
  874  706  437
  944  536  357
  726  919  349
  911  791  637
  447  224  483
  742  941  693
  632   42  918
  302  907  547
  204  618  927
   86  765   15
  280  396  926
  857  422  560
  801  355  368
   53  718  577
  613  946  933
  641  378  563
   39  928  423
  252  906  454
  626  318   81
  477  838  407
   85  531  475
  129  622  419
  184  372  147
  364  805  559
  445  128  302
  656  813  724
  485  140  509
  537  267  549
  164  184   89
  464  231  881
  111   63  706
  383  283  567
  408   31  455
  698  864  501
  692  887  753
  573  681  783
  453  393  338
  171  707  850
   68  663  190
  342  588  284
  309  218  102
  121  743   56
  321  722  379
  307   99  357
  444  485  636
  548  419  517
  407  101  714
  168  496  140
  111  520  594
   55  129  476
  706  849   93
  529  200  416
  848  680  470
  731  189   61
  591  689   20
  801  777   52
  395  449  821
  337  421  292
  618  208  674
  116   13   66
  459  790  615
  429  796  565
  891  795  903
  929  443  263
   49  694  890
  708  929  577
  764  786  554
  971  473  236
  271  483  440
  666  506  858
  582  959  594
  470  918  457
  583  662  551
  777  446  214
  609  503  929
  861  691  766
  256  201  940
  894  386  172
  624  397   17
  615    9  159
  454  494  344
  606  717  995
  251  333  688
  714  910  670
  531  346  227
  693  754  745
  947    8  411
    9  862  598
  937  858  601
  309  977   18
  731  684  943
  579  384  958
  359  647  495
    8  355  476
  363  459   21
  712  383  997
  892   71  981
  374  433  156
   86  194  341
   60  298  385
   31  110  452
  813  501  635
  249   82  215
  895  585  456
  571  961  784
  734  746  854
  742  268   73
  575    7  583
  660  643  908
  559  643  336
  222  725  935
  660   82  939
  709  745   41
  277  504  918
  604  679  913
  717  419  183
  613  306  732
  491  694  742
  628  707  108
  885  867  527
  970  740  567
  147  267  119
  288  766  969
  132  190  372
  175  862  992
  942  468  639
   63  908  581
  939  703  830
  328  186  554
  936  130  355
  865  270  479
  253  104  444
   99  378  107
  342  385  340
  651  480  324
   14  841  249
  635  538   79
  229  415  530
  489  931  329
  654  828  719
  911  703  693
  202  425  201
  897  314  745
  126  606  323
  201  459  307
   79  719   51
  595  913  432
  261  980  554
  708  272  591
  423  754   58
  175  538  449
  552  671  418
  871   86  809
    5  579  309
  877  635  850
  607  621  470
  584  166  732
  443  666  887
  305  612  454
  547  252   90
  324  431  510
  827  912  501
  329  868  593
  524  944  461
   10  709  299
  902   76  539
  894  783  448
  304  883  270
  358  716  346
  626  192  530
  900   47  880
  807  796  757
  672  774  885
  596  391  358
  300  355  318
  617   44  310
  363   51  907
  138  183  704
  243  184  234
  977  406  460
  811  692  579
  412  459  196
  509  346  366
  697  646  777
  247  930  583
  383  268   54
  387   11  471
  434  273  444
  462  191  917
  474  236  605
  924  192  348
  515   15  128
  398  609  300
  608  627  296
  289  624  427
   16  448   70
  280  329  492
  186  448  444
  709   27  239
  566  472  535
  395  737  535
  666  108  512
  398  788  762
  187   46  733
  689  389  690
  717  350  106
  243  988  623
   13  950  830
  247  379  679
  654  150  272
  157  229  213
  710  232  314
  585  591  948
  193  624  781
  504  553  685
  135   76  444
  998  845  416
  901  917   69
  885  266  328
   32  236  487
  877  223  312
  602  264  297
  429  852  180
  558  833  380
  579  341  829
  708  823  603
  480  625  551
  168  995  465
   24  236  898
  180  770  985
  827  126  352
  790  491  324
  198  379  105
  953  609  224
  793  519  389
  988  303  169
  636  575  937
  460  869  500
  859  552  819
  647  650  366
  838  643  233
  223  170  244
  689  381  542
   15  293  371
  696  443  796
  549  128  525
  919  719  231
  651  599  417
  413   80  413
  864  940  344
  753  989  342
  583  816   28
  399  818  894
  522    1  884
  105  122  148
    2  868  301
  100  945  306
  990  516  458
  604  484   27
  587   36  468
  774  726  241
  931  993  277
  908  406  352
  783  586  706
  760   27  469
   42  611  958
   72  118  399
  526  638   55
  598  737  392
  134   84  825
  734  804  273
  600  778  888
  788  539  691
   57  854  592
  824  629  286
  359   24  824
  548  857  646
  820  831  194
   29  842  939
  966  133  201
  992  709  970
  357   44   29
  320  649  356
   35  611  379
  407  894  581
  408  940  680
  652  367  124
  630  200  182
  652  271  828
   65  296  786
  821   42  341
   84   24  562
  894   29  500
  739  799  310
  289  461  385
  540  731  430
  393  303  389
  756  560  731
  637  470  761
  105  314  202
  339  437  717
  256  526  810
  639  382  381
   11  289  290
  638  450  336
  602  415  901
  671  494  718
  460  507  186
  596  160  528
  766  811  389
  319  955  281
   24  317  562
  489  870  295
  514  924  477
  386  887   49
  479  940  432
  558  523  416
  343   53   46
  542  803  597
  696  784  565
  474  495  650
  613  692  465
  352  841  199
  911  927  640
  273  693  512
  701  468  597
  144  915  630
  949  967  185
  952  293  538
  642  426  249
  788  408  678
  457   32  579
  571  462  686
  650  752  651
  260  681  182
  158   89  312
  693  336  517
  812  355  634
  216  507  591
  643  520  310
  769   18  896
  630  852  677
  566  912  185
  643  621  739
  433  347   52
  691  413  758
  262  458  761
  882  877  576
  914  254  194
  407  919  511
  826  345  490
  551  187  611
  501  163  507
   59  749  708
  364  502  718
  390  317   38
  316   77  424
  400  834  339
  296  868  102
  360  533   38
  326  607  529
  442  962  544
  773  371  300
   22    6  300
  789  378  386
  643  461   14
  486  312   75
  901  428   73
  275  734  871
  384  793  475
  197   59  798
  662  682  342
  812  638  459
  461   59  642
  895  253  990
  693  128  596
  415  270  537
  587  193  575
  265  644  638
  745  661   61
  465  712  251
  269  617  285
  257  958  442
  387  120  612
  776  833  198
  734  948  726
  946  539  878
   58  776  787
  970  235  143
  129  875  350
  561  999  180
  496  609  390
  460  184  184
  618  137   25
  866  189  170
  959  997  911
  631  636  728
  466  947  468
   76  708  913
   70   15  811
   65  713  307
  110  503  597
  776  808  944
  854  330  755
  978  207  896
  850  835  978
  378  937  657
  403  421  492
  716  530   63
  854  249  518
  657  998  958
  355  921  346
  761  267  642
  980   83  943
  691  726  115
  342  724  842
  859  144  504
  978  822  631
  198  929  453
  657  423  603
  687  450  417
  297   44  260
  158  460  781
   29  108  744
  136  486  409
  941  659  831
   71  606  640
  908  251  372
  403  180  857
  458  598   52
  184  594  880
   38  861  395
  302  850  883
  262  580  667
    2  905  843
  474  825  794
  473  209   96
  926  833  585
  903  119  532
   23  712  831
  875  558  406
  146  635  851
  844  703  511
  900  530  612
  824   21  356
  746  511  721
  737  445  326
  644  162  309
  892  291   17
  105  581  795
  318  869  402
  408  289  535
  656  444   83
  647  754  133
   43  901  205
  386  420  766
  549   90  859
  756  436  188
  664  491  753
  700  402  573
  403  590  189
  258  982   20
    4  553  529
  264  718  538
  206  647  136
  257  860  279
  338  449  249
  421  569  865
  188  640  124
  487  538  796
  276  358  748
  269  260  625
   83  106  309
  496  340  467
  456  953  179
  461  643  367
  411  722  222
  519  763  677
  550   39  539
  135  828  760
  979  742  988
  868  428  315
  423  535  869
  677  757  875
  853  415  618
  591  425  937
  585  896  318
  207  695  782
  200  904  131
   95  563  623
  176  675  532
  493  704  628
  707  685  521
  690  484  543
  584  766  673
  667  933  617
  276  416  577
  808  966  321
  327  875  145
  660  722  453
  769  544  355
   83  391  382
  837  184  553
  111  352  193
   67  385  397
  127  100  475
  167  121   87
  621   84  120
  592  110  124
  476  484  664
  646  435  664
  929  385  129
  371   31  282
  570  442  547
  298  433  796
  682  807  556
  629  869  112
  141  661  444
  246  498  865
  605  545  105
  618  524  898
  728  826  402
  976  826  883
  304    8  714
  211  644  195
  752  978  580
  556  493  603
  517  486   92
   77  111  153
  518  506  227
   72  281  637
  764  717  633
  696  727  639
  463  375   93
  258  772  590
  266  460  593
  886  950   90
  699  747  433
  950  411  516
  372  990  673
   69  319  843
  333  679  523
  394  606  175
  640  923  772
  893  657  638
  563  285  244
  874  579  433
  387  758  253
  389  114  809
  736  269  738
  345  173  126
  248  793  502
  422  271  583
  399  528  654
  825  956  348
  822  378   52
    7  658  313
  729  371  395
  553  267  475
  624  287  671
  806   34  693
  254  201  711
  667  234  785
  875  934  782
  107   45  809
  967  946   30
  443  882  753
  554  808  536
  876  672  580
  482   72  824
  559  645  766
  784  597   76
  495  619  558
  323  879  460
  178  829  454
   12  230  592
   90  283  832
   81  203  452
  201  978  785
  643  869  591
  647  180  854
  343  624  137
  744  771  278
  717  272  303
  304  298  799
  107  418  960
  353  378  798
  544  642  606
  475  300  383
  445  801  935
  778  582  638
  938  608  375
  342  481  512
  666   72  708
  349  725  780
  368  797  163
  342  815  441
  167  959  681
  499  199  813
  475  461  495
  354  462  532
  390  730  369
  202  623  877
  656  139  883
  495  666    8
  348  955  976
  998  356  906
  725  645  938
  353  539  438
  982  470  636
  651  140  906
  895  706  538
  895  721  203
  158   26  649
  489  249  520
  320  157  751
  810  274  812
  327  315  921
  639   56  738
  941  360  442
  117  419  127
  167  535  403
  118  834  388
   97  644  669
  390  330  691
  339  469  119
  164  434  309
  777  876  305
  668  893  507
  946  326  440
  822  645  197
  339  480  252
   75  569  274
  548  378  698
  617  548  817
  725  752  282
  850  763  510
  167    9  642
  641  927  895
  201  870  909
  744  614  678
   44   16  322
  127  164  930
  163  163  672
  945  865  251
  647  817  352
  315   69  100
   66  973  330
  450  972  211
  401   38  225
  561  765  753
  554  753  193
  222   13  800
  124  178  456
  475  703  602
  420  659  990
  487   94  748
  578  284  577
  776  355  190
  194  801  566
   42  124  401
  179  871  669
  303  123  957
  596  503  820
  846  424  985
  522  882  254
  835  811  405
  796   94  209
  185  355  394
  387  145  223
  300  240  395
  381  826  899
  503  868  606
  121  675  467
  159  456  724
   28  477  233
  165   43  566
  159  404   26
  969  413  725
  927  389  733
  720  345   38
  752  197  879
  219  196  866
  583  195   84
  654  996  364
  234  941  298
  136  890  732
  147  296  874
  245  948  627
  633  404  794
  443  689  477
  819  923  324
  391  821  683
  774  255  339
  684  856  391
  751  420  608
  594  884  207
  280  903  472
  365  916  620
  421    1  760
   66  913  227
   73  631  787
  471  266  393
  469  629  525
  534  210  781
  765  198  630
  654  236  771
  939  865  265
  362  849  243
  670   22  225
  269  644  843
   30  586   15
  266  178  849
  237  547  926
  908   33  574
  788  525  895
  717  448  413
  951    4  254
  931  447  158
  254  856  371
  941  803  322
  697  678   99
  339  508  155
  958  608  661
  639  356  692
  121  320  969
  222   47   76
  130  273  957
  243   85  734
  696  302  809
  665  375  287";
            var d03 = new Day03(input);
            d03.ParseTriangles();
            Console.WriteLine($"Day 03");
            Console.WriteLine($"------");
            Console.WriteLine($"There are {d03.NumberOfPossibleTriangles} possible triangles");
            d03 = new Day03(input, true);
            d03.ParseTriangles();
            Console.WriteLine($"There are {d03.NumberOfPossibleTriangles} possible triangles");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");


            // /////////////////////////////////////////////////
            // Day 02
            // /////////////////////////////////////////////////
        
            input = @"LLULLLRLDLLLRLUURDDLRDLDURULRLUULUDDUDDLLLURRLDRRLDRRRLDUDLRDLRRDLLDUDUDUDRLUDUUDLLLRDURUDUULUDLRDUUUDUUDURLDUULLRDLULDUURUDRDDLDRLURLRURRDUURLRLUURURUUULLRLLULRUURLULURDLLRRUDLUDULDRDRLRULUURRDRULLRUUUDLRLDLUURRRURDLUDDRRUDRLUDRDLLLLLRULLDUDRLRRDDULDLRUURRRRRLDLDLRDURDRUUURDLRDDDDULURRRRDUURLULLLDLRULRDULRUDLRRLRDLLRLLLUDDLRDRURDDLLLLDUDRDLRURRDLRDDDLDULDRLRULUUDRRRUUULLLURRDDUULURULDURRLLULLDRURUUULRLRDRRUDRDRRDURRUUUULDRDDDUDLDDURLLRR
LDLRRRUURDLDDRLRRDLLULRULLLUDUUDUDLRULLDRUDRULLDULURDRDDLRURDDULLLLDLRDRDRDDURLURLURLUDRDDRDULULUDDRURRDLLDUURDRDDLRLLURRDLRDDULDLULURDRDLUDRRUUDULLULURRDUDRUUUDRULDLDURLRRUDURLDLRRUURRRURDLUDRLDUDRRUDUURURUDDUUDRDULRDLUDRRRLDRURLLRDDDLUDRDUDURDDDRRDDRRRLLRRDDLDDLRUURRURDLLDRLRRDLLUDRRRURURLRDRLLRLRLRULLRURLDLRRULLRRRDULUUULDRDLLURDDLDLRDRLUUDLLUDDLDRRLDLRUDRUDLLUURLLULURUDUDRLULLUDRURDDLDLDDUDLRDDRRURLRLLUDDUDRUURRURRULDRLDDRLLRRLDDURRDLDULLLURULLLRUURLRRRRUUULRLLLURRLRLRUDRDUUUDUUUDDLULLDLLLLDLDRULDRUUULDDDLURLDLRLULRUDDDDURDDLU
RURLURRDLDULLULDDDLRUULLUURLRUDRUDRRUDDLDDDDRRDLRURLRURLDDDUDDUURRDRULDRRRULRDRDDLRUDULRLURDUUDRRLDLRDRURDLDRRRRDRURUUDDDLLRDRDUDUDUDLLULURULRRLRURUULUULDDDDURULRULLRUDUURLURDUDLUDLUDRLLDUUDUULRLRLUUDRDULDULRURDRRRULRUDLRURDDULUDULLRLRURURUULLULDRURLLRRUUDDUUURRDLURUURULRDRRDDUDULRDDLUDLURURUURDRULLRDDLLRDDLDRDUDRRDLUURRLRLUURRULUDURLDDRLLURRDDDLDDRURULLDDRLUDDLRLURDUDULLRDULLLDLLUDDRUDRUDDUUDRDRULRL
RLRDRDULULUDLUDRDRLUDLDLLUDURULDDDUDLRURLLRLRLDLDRLDURDLRRURLULLULURLLDRRDRLUDRLRDLLULRULURRURURUULRDUDLLRDLRRRRRLUURDRRRDLRUDLLDLLDLRUUUDLLLDDDLRDULLRUUDDRLDDURRRDLRLRLDDDDLRDRULLUURUUDRRLLRLLRDDLLRURRRRDRULRRLLRLLLRLDRRLDDDURRURLDURUURRLRLRLDRURULLRLRUDLDUURDLLRLDLURUUUDLLRDRDDDDDDRLDRRRLRRRRURUDLDDRDLLURUDLRRLDDDLUDUDUULRDULULUDDULUUDLLLLRLDDUUULRLRDULURDURRRURRULURRRDRDLDDURDLURUDURRRDDRLRLUDLUDDLUULLDURLURDDUDDLRUUUDRLLDRURL
ULUDLLUDDULRUURDRURDUDUDLUURDDDRRLUDURURDRURRLDRDURLRLLRRDDRRDRRRUULURUDURUDULRRRRDDLDURRLRRDUDDDRLLLULDRLRLURRDUURDURRRURRDLUDUDDRLDLURRRDDRLLRDRDDRDURRRRLURRLUDDURRULRUDUDULDRUDDRULLUUULDURRRLDRULLURULLRUDLDUDDLDULDLUUDRULULDLLDRULLRUULDUDUUDRLRRLDLUULUDLLDDRLRRDDLLURURDULRRDDRURDRLRLULDLDURULLUUUDURURDLDUDDDDUUULUDLUURRULLDLRLURDLURLRLDDURRLDDRRRDUUULLUULDLLDLLDDRLRRUDLULDRLULDULULRRLRULUUURURUUURDUUDDURLLUDDRLRDDLUURRUULRDLDDRLULUULRDRURLUURDRDUURUDLRR";
            var d02 = new Day02();
            d02.Instructions = input;
            d02.ParseInstructions();
            Console.WriteLine($"Day 02");
            Console.WriteLine($"------");
            Console.WriteLine($"The code is: {d02.Code}");d02 = new Day02();
            d02.Instructions = input;
            d02.ParseInstructions(d02.Move_13);
            Console.WriteLine($"The code is: {d02.Code}");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 01
            // /////////////////////////////////////////////////
        
            input = "L2, L5, L5, R5, L2, L4, R1, R1, L4, R2, R1, L1, L4, R1, L4, L4, R5, R3, R1, L1, R1, L5, L1, R5, L4, R2, L5, L3, L3, R3, L3, R4, R4, L2, L5, R1, R2, L2, L1, R3, R4, L193, R3, L5, R45, L1, R4, R79, L5, L5, R5, R1, L4, R3, R3, L4, R185, L5, L3, L1, R5, L2, R1, R3, R2, L3, L4, L2, R2, L3, L2, L2, L3, L5, R3, R4, L5, R1, R2, L2, R4, R3, L4, L3, L1, R3, R2, R1, R1, L3, R4, L5, R2, R1, R3, L3, L2, L2, R2, R1, R2, R3, L3, L3, R4, L4, R4, R4, R4, L3, L1, L2, R5, R2, R2, R2, L4, L3, L4, R4, L5, L4, R2, L4, L4, R4, R1, R5, L2, L4, L5, L3, L2, L4, L4, R3, L3, L4, R1, L2, R3, L2, R1, R2, R5, L4, L2, L1, L3, R2, R3, L2, L1, L5, L2, L1, R4";
            var d01 = new Day01(input);
            d01.MoveAlongThePath();
            Console.WriteLine($"Day 01");
            Console.WriteLine($"------");
            Console.WriteLine($"You are {d01.GetBlocksAwayFromStart()} blocks away");
            Console.WriteLine($"The first location visited twice is {d01.FirstVisitedLocationTwice} blocks away");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

        }
    }
}
