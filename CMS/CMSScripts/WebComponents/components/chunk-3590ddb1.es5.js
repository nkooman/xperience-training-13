/*! Built with http://stenciljs.com */
var __awaiter=this&&this.__awaiter||function(e,n,t,i){return new(t||(t=Promise))(function(o,r){function l(e){try{c(i.next(e))}catch(e){r(e)}}function a(e){try{c(i.throw(e))}catch(e){r(e)}}function c(e){e.done?o(e.value):new t(function(n){n(e.value)}).then(l,a)}c((i=i.apply(e,n||[])).next())})},__generator=this&&this.__generator||function(e,n){var t,i,o,r,l={label:0,sent:function(){if(1&o[0])throw o[1];return o[1]},trys:[],ops:[]};return r={next:a(0),throw:a(1),return:a(2)},"function"==typeof Symbol&&(r[Symbol.iterator]=function(){return this}),r;function a(r){return function(a){return function(r){if(t)throw new TypeError("Generator is already executing.");for(;l;)try{if(t=1,i&&(o=2&r[0]?i.return:r[0]?i.throw||((o=i.return)&&o.call(i),0):i.next)&&!(o=o.call(i,r[1])).done)return o;switch(i=0,o&&(r=[2&r[0],o.value]),r[0]){case 0:case 1:o=r;break;case 4:return l.label++,{value:r[1],done:!1};case 5:l.label++,i=r[1],r=[0];continue;case 7:r=l.ops.pop(),l.trys.pop();continue;default:if(!(o=(o=l.trys).length>0&&o[o.length-1])&&(6===r[0]||2===r[0])){l=0;continue}if(3===r[0]&&(!o||r[1]>o[0]&&r[1]<o[3])){l.label=r[1];break}if(6===r[0]&&l.label<o[1]){l.label=o[1],o=r;break}if(o&&l.label<o[2]){l.label=o[2],l.ops.push(r);break}o[2]&&l.ops.pop(),l.trys.pop();continue}r=n.call(e,l)}catch(e){r=[6,e],i=0}finally{t=o=0}if(5&r[0])throw r[1];return{value:r[0]?r[1]:void 0,done:!0}}([r,a])}}};components.loadBundle("chunk-3590ddb1.js",["exports"],function(e){for(var n=this,t=window.components.h,i=[],o=0;o<256;++o)i[o]=(o+256).toString(16).substr(1);var r,l,a,c,s=function(e,n,t){window.parent.postMessage({msg:e,data:n},t)},u={LocalizationService:Symbol.for("LocalizationService"),NormalizerService:Symbol.for("NormalizerService"),PageConfigurationService:Symbol.for("PageConfigurationService"),PopUpElementsService:Symbol.for("PopUpElementsService"),MessagingService:Symbol.for("MessagingService")};!function(e){e.SAVE_CONFIGURATION="Kentico.SaveConfiguration",e.LOAD_DISPLAYED_WIDGET_VARIANTS="Kentico.LoadDisplayedWidgetVariants",e.GET_DISPLAYED_WIDGET_VARIANTS="Kentico.GetDisplayedWidgetVariants",e.CONFIGURATION_STORED="Kentico.ConfigurationStored",e.CONFIGURATION_CHANGED="Kentico.ConfigurationChanged",e.MESSAGING_ERROR="Kentico.Messaging.Error",e.MESSAGING_EXCEPTION="Kentico.Messaging.Exception",e.MESSAGING_WARNING="Kentico.Messaging.Warning",e.MESSAGING_DRAG_START="Kentico.Messaging.DragStart",e.MESSAGING_DRAG_STOP="Kentico.Messaging.DragStop",e.OPEN_MODAL_DIALOG="Kentico.OpenModalDialog",e.CLOSE_MODAL_DIALOG="Kentico.CloseModalDialog",e.SAVE_TEMP_CONFIGURATION="Kentico.SaveTempConfiguration",e.TEMP_CONFIGURATION_STORED="Kentico.TempConfigurationStored",e.CHANGE_TEMPLATE="Kentico.ChangeTemplate",e.CANCEL_SCREENLOCK="Kentico.CancelScreenLock"}(r||(r={})),(l=e.Theme||(e.Theme={})).Widget="widget",l.Section="section",l.Template="template",(a=e.ButtonType||(e.ButtonType={})).Properties="properties",a.Change="change",a.Personalization="personalisation",a.Delete="delete",a.Move="move";var d={logError:function(e){s(r.MESSAGING_ERROR,e,"*")},logException:function(e){console.error(e),s(r.MESSAGING_EXCEPTION,(c=u.LocalizationService,null.get(c)).getLocalization("errors.generalerror"),"*")},logExceptionWithMessage:function(e,n){console.error(e),s(r.MESSAGING_EXCEPTION,n,"*")},logWarning:function(e){s(r.MESSAGING_WARNING,e,"*")}},f="undefined"!=typeof window?window:"undefined"!=typeof global?global:"undefined"!=typeof self?self:{};e.changeFileHandler=function(e,n){var t=this;void 0===n&&(n={});var i=this.selectedFiles.findIndex(function(n){return n.fileGuid===e});this.openDialog(Object.assign({},n,{maxFilesLimit:1,allowedExtensions:this.allowedExtensions,selectedValues:[{fileGuid:e}],applyCallback:function(n){if(void 0===n&&(n=[]),1===n.length){var o=n[0];if(o.fileGuid===e)return;var r=t.selectedFiles.slice();t.selectedFiles.filter(function(e){return e.fileGuid===o.fileGuid}).length>0?r.splice(i,1):r[i]=o,t.selectedFiles=r}}}))},e.selectFileHandler=function(e){var n=this;void 0===e&&(e={}),this.openDialog(Object.assign({},e,{maxFilesLimit:this.maxFilesLimit,allowedExtensions:this.allowedExtensions,selectedValues:this.selectedFiles.map(function(e){return{fileGuid:e.fileGuid}}),applyCallback:function(e){if(void 0===e&&(e=[]),1===n.maxFilesLimit)if(1===e.length){var t=e[0];if(n.selectedFiles.length&&t.fileGuid===n.selectedFiles[0].fileGuid)return;n.selectedFiles=[t]}else n.clear();else if(e.length>0){var i=n.selectedFiles.filter(function(e){return!e.isValid});n.selectedFiles=function(e,n){var t=[];return e.forEach(function(e){var i=n.find(function(n){return n.fileGuid===e.fileGuid});i?t.push(i):t.push(e)}),t}(e,i)}else n.clear()}}))},e.removeScriptElements=function(e){var n=document.head.querySelectorAll("."+e);Array.prototype.forEach.call(n,function(e){e.remove()})},e.renderMarkup=function(e,n,t){n.innerHTML=e;var i=n.querySelectorAll("script");Array.prototype.forEach.call(i,function(e){var n=e.parentNode,i=document.createElement("script");try{e.src?(i.classList.add("ktc-tmp-element"),i.classList.add(t),i.src=e.src,i.type=e.type,document.head.appendChild(i)):(i.innerHTML=e.innerHTML,n.replaceChild(i,e)),e.remove()}catch(e){d.logException(e)}})},e.commonjsGlobal=f,e.createCommonjsModule=function(e,n){return e(n={exports:{}},n.exports),n.exports},e.POP_UP_CONTAINER_WIDTH=300,e.logger=d,e.lineClamp=function(e,n){var t,i,o=e.innerHTML,r="…",l=[".","-","–","—"," ","_"].slice(0),a=l[0],c=function(n,u){var d=o.replace(r,"");if(t||(a=l.length>0?l.shift():"",t=d.split(a)),t.length>1?(i=t.pop(),s(n,t.join(a))):t=null,t&&e.clientHeight<=u){if(""===a)return;s(n,t.join(a)+a+i),t=null}c(n,u)};function s(e,n){e.innerHTML=n+r}var u=parseInt(getComputedStyle(e).getPropertyValue("line-height"),10)*n;u<e.clientHeight&&c(e,u)},e.fetchData=function(e,t,i){return void 0===t&&(t="GET"),void 0===i&&(i=null),__awaiter(n,void 0,void 0,function(){return __generator(this,function(n){return[2,fetch(e,{method:t,headers:{"Content-Type":"application/json",pragma:"no-cache","cache-control":"no-cache"},body:null!==i?JSON.stringify(i):null})]})})},e.getSelectedValues=function(e,n,t){if(t<0)throw new Error("Parameter 'limit' cannot be less than 0.");var i=n;return n.includes(e)?1!==t&&(i=n.filter(function(n){return n!==e})):1===t?i=[e]:(n.length<t||0===t)&&(i=n.concat([e])),i},e.renderCounter=function(e,n,i){return t("div",{class:{"ktc-counter":!0,"ktc-counter-visible":e>0},title:0!==n?i("kentico.components.selector.selecteditemscount.limited",e,n):i("kentico.components.selector.selecteditemscount.notlimited",e)},e,0!==n?"/"+n:"")},e.renderError=function(e){return t("div",{class:"ktc-message-box"},e)},e.renderLoader=function(e){return t("div",{class:"ktc-loader-container-wrapper"},t("div",{class:"ktc-loader-container"},t("kentico-loader",{loaderMessage:e("kentico.builder.modaldialogs.loading"),delayed:!0})))},e.DIALOG_FOOTER_HEIGHT=64,e.DIALOG_HEADER_HEIGHT=36});